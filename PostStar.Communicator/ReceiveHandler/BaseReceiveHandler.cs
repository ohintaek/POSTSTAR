﻿using Mina.Core.Service;
using Mina.Core.Session;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostStar.Communicator.ReceiveHandler
{

    /// <summary>
    /// Base Recieve Handler
    /// </summary>
    public class BaseReceiveHandler : IoHandlerAdapter
    {
        IDictionary<IoSession, Boolean> sessions = new ConcurrentDictionary<IoSession, Boolean>();
        IDictionary<String, Boolean> users = new ConcurrentDictionary<String, Boolean>();

        public void Broadcast(String message)
        {
            foreach (IoSession session in sessions.Keys)
            {
                if (session.Connected)
                    session.Write("BROADCAST OK " + message);
            }
        }

        public override void ExceptionCaught(IoSession session, Exception cause)
        {
            Console.WriteLine("Unexpected exception." + cause);
            session.Close(true);
        }

        public override void SessionOpened(IoSession session)
        {
            Console.WriteLine("Accept ....");
        }

        public override void SessionClosed(IoSession session)
        {
            String user = session.GetAttribute<String>("user");
            sessions.Remove(session);
            if (user != null)
            {
                users.Remove(user);
                Broadcast("The user " + user + " has left the chat session.");
            }
        }

        public override void MessageReceived(IoSession session, Object message)
        {
            String theMessage = (String)message;
            String[] result = theMessage.Split(new Char[] { ' ' }, 2);
            String theCommand = result[0];

            String user = session.GetAttribute<String>("user");

            if (String.Equals("QUIT", theCommand, StringComparison.OrdinalIgnoreCase))
            {
                session.Write("QUIT OK");
                session.Close(true);
            }
            else if (String.Equals("LOGIN", theCommand, StringComparison.OrdinalIgnoreCase))
            {
                if (user != null)
                {
                    session.Write("LOGIN ERROR user " + user + " already logged in.");
                    return;
                }

                if (result.Length == 2)
                {
                    user = result[1];
                }
                else
                {
                    session.Write("LOGIN ERROR invalid login command.");
                    return;
                }

                // check if the username is already used
                if (users.ContainsKey(user))
                {
                    session.Write("LOGIN ERROR the name " + user + " is already used.");
                    return;
                }

                sessions[session] = true;
                session.SetAttribute("user", user);

                // Allow all users
                users[user] = true;
                session.Write("LOGIN OK");
                Broadcast("The user " + user + " has joined the chat session.");
            }
            else if (String.Equals("BROADCAST", theCommand, StringComparison.OrdinalIgnoreCase))
            {
                if (result.Length == 2)
                {
                    Broadcast(user + ": " + result[1]);
                }
            }
            else
            {
                Console.WriteLine("Unhandled command: " + theCommand);
            }
        }
    }
}
