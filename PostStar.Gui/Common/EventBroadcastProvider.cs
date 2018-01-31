﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace PostStar.Gui.Common
{
    /// <summary>
    ///     This class broadcasts a specific event up through all the 
    ///     ancestors of the target control.
    /// </summary>
    public abstract class EventBroadcastProvider : IDisposable
    {
        protected EventBroadcastProvider() { }

        /// <summary>
        ///     Handler called when the target event is raised.  This handler
        ///     will then dispatch to all ancestor controls.
        /// </summary>
        /// <param name="sender">
        ///     The original control that triggered this handler.
        /// </param>
        /// <param name="ea">
        ///     The original event arguments.
        /// </param>
        /// <remarks>
        ///     Because this handler is hooked into every ancestor class for the 
        ///     target event, and because the Onxxx method is called for all classes, 
        ///     this handler will be called for all controls visited.  We only want
        ///     this to be raised for the control that directly raised the event.
        ///     To prevent reentry, a flag is set when the first it entered, then 
        ///     cleared upon exist of that same invocation.
        /// </remarks>
        protected void Relay(object sender, EventArgs ea)
        {
            //
            // Make sure to end when the target control is the only one that send
            // the event.  This is because it is assumed that there is already
            // that event being handled directly.
            //
            if (object.ReferenceEquals(sender, m_control))
            {
                if (m_chain != null) m_chain.Add((Control)sender);
                return;
            }

            //
            // Record the controls as they are relayed so they can be
            // passed using the Relayed event.
            //
            if (m_chain == null)
                m_chain = new List<Control>();
            m_chain.Add((Control)sender);

            //
            // Must flag object to prevent reentry.
            //
            if (m_noReentry) return;

            //
            // Locate the event method used to raise the event.  Currently
            // must be in the format On<EventName>(...).
            //
            string eventMethName =
                String.Format(EventMethodTemplate, m_eventName);

            //
            // Invoke the event passing the event arguments for each ancestor
            //
            m_noReentry = true;
            Control curControl = ((Control)sender).Parent;
            while (curControl != null)
            {
                MethodInfo mi =
                    curControl.GetType().GetMethod(eventMethName, BindingFlags.NonPublic |
                                                                  BindingFlags.Public |
                                                                  BindingFlags.FlattenHierarchy |
                                                                  BindingFlags.Instance);

                //
                // Ignore any classes that do not support the event.
                //
                if (mi != null)
                {
                    mi.Invoke(curControl, new object[] { ea });
                }

                //
                // End loop it target control has been reached.
                //
                if (object.ReferenceEquals(curControl, m_control))
                    break;

                //
                // Get the parent, or null if no parent exists.
                //
                curControl = curControl.Parent;
            }
            m_noReentry = false;

            OnRelayed(new RelayedEventArgs(m_chain.ToArray()));
            m_chain = null;
        }

        /// <summary>
        ///     Returns a class used to hook the specified event.  This class
        ///     is dynamically generated to provide a strongly-typed connection
        ///     with the event delegation.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public static EventBroadcastProvider
            CreateProvider(Control control, string eventName)
        {
            //
            // Dynamically create inherited class that is strongly typed
            // for the event handler.
            //
            EventInfo ei = control.GetType().GetEvent(eventName);
            EventBroadcastProvider broadcastProvider = CreateHandlerForEvent(ei);
            broadcastProvider.Bind(control, eventName);

            return broadcastProvider;
        }

        /// <summary>
        ///     Gets the name of the event that will be monitored.
        /// </summary>
        public string EventName
        {
            get { return m_eventName; }
        }

        /// <summary>
        ///     Gets the control that is the parent for all controls monitored.
        /// </summary>
        public Control Control
        {
            get { return m_control; }
        }

        /// <summary>
        ///     Returns a derived instance of <see cref="EventBroadcastProvider"/> that 
        ///     matches the types required by the targeted event handler.
        /// </summary>
        /// <param name="ei"></param>
        /// <returns></returns>
        private static EventBroadcastProvider CreateHandlerForEvent(EventInfo ei)
        {
            EventBroadcastProvider result = null;

            string namespaceName = typeof(EventBroadcastProvider).Namespace;
            string eventName = ei.Name;
            string className = eventName + "BroadcastProvider";

            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = className + "Assembly";

            AppDomain appDomain = AppDomain.CurrentDomain;

            AssemblyBuilder assBuilder =
                appDomain.DefineDynamicAssembly(assemblyName,
                                                AssemblyBuilderAccess.Run);
            ModuleBuilder modBuilder =
                assBuilder.DefineDynamicModule(className + "Module");
            TypeBuilder typBuilder =
                modBuilder.DefineType(className,
                                      TypeAttributes.Public,
                                      typeof(EventBroadcastProvider));


            FieldBuilder fldBuilder =
                typBuilder.DefineField("m_handler",
                                       typeof(Delegate),
                                       FieldAttributes.Private);

            ILGenerator ilGen = null;

            //
            // Build the RelayDelegate property.
            //
            PropertyBuilder relayDelegateBuilder =
                typBuilder.DefineProperty("RelayDelegate",
                                          PropertyAttributes.None,
                                          typeof(Delegate), null);
            MethodBuilder get_relayDelegateBuilder =
                typBuilder.DefineMethod("get_RelayDelegate",
                                        MethodAttributes.HideBySig |
                                        MethodAttributes.Virtual |
                                        MethodAttributes.Family |
                                        MethodAttributes.SpecialName,
                                        typeof(Delegate), null);

            ilGen = get_relayDelegateBuilder.GetILGenerator();
            ilGen.DeclareLocal(typeof(Delegate));
            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Ldfld, fldBuilder);
            ilGen.Emit(OpCodes.Stloc_0);
            ilGen.Emit(OpCodes.Ldloc_0);
            ilGen.Emit(OpCodes.Ret);

            relayDelegateBuilder.SetGetMethod(get_relayDelegateBuilder);

            //
            // Build the HandleEvent method.
            //
            MethodBuilder handleEventBuilder =
                typBuilder.DefineMethod("HandleEvent",
                MethodAttributes.Private | MethodAttributes.HideBySig,
                null,
                new Type[] { typeof(object),
                    ei.EventHandlerType.GetMethod("Invoke").GetParameters()[1].ParameterType });
            ilGen = handleEventBuilder.GetILGenerator();

            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Ldarg_1);
            ilGen.Emit(OpCodes.Ldarg_2);
            ilGen.Emit(OpCodes.Call,
                typeof(EventBroadcastProvider).GetMethod("Relay",
                BindingFlags.Instance | BindingFlags.NonPublic));
            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Ret);

            //
            // Build the constructor.
            //
            ConstructorBuilder ctorBuilder =
                typBuilder.DefineConstructor(MethodAttributes.Public |
                                             MethodAttributes.HideBySig,
                                             CallingConventions.HasThis, null);

            ilGen = ctorBuilder.GetILGenerator();
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Ldnull);
            ilGen.Emit(OpCodes.Stfld, fldBuilder);
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Call,
                typeof(EventBroadcastProvider).
                GetConstructor(BindingFlags.Instance |
                               BindingFlags.NonPublic, null,
                               Type.EmptyTypes, null));
            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Ldarg_0);
            ilGen.Emit(OpCodes.Ldftn, handleEventBuilder);
            ilGen.Emit(OpCodes.Newobj, ei.EventHandlerType.GetConstructors()[0]);
            ilGen.Emit(OpCodes.Stfld, fldBuilder);
            ilGen.Emit(OpCodes.Nop);
            ilGen.Emit(OpCodes.Ret);

            result =
                (EventBroadcastProvider)Activator.
                    CreateInstance(typBuilder.CreateType());

            return result;
        }

        /// <summary>
        ///     Hooks the necessary events to the event handlers so this object
        ///     can monitor the control.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="eventName"></param>
        private void Bind(Control control, string eventName)
        {
            m_control = control;
            m_eventName = eventName;

            m_controlAddedHandler =
                new ControlEventHandler(ControlAddedHandler);
            m_controlRemovedHandler =
                new ControlEventHandler(ControlRemovedHandler);
            m_genericHandler = RelayDelegate;

            HookPrimaryEvents(control);
        }

        /// <summary>
        ///     Hooks any events necessary for correct operations.  These hooks watch
        ///     all controls in a hierarchy for changes such as controls being
        ///     added or removed.
        /// </summary>
        /// <param name="control">
        ///     The target control (which will recursivly scan).
        /// </param>
        private void HookPrimaryEvents(Control control)
        {
            //
            // hook static events.
            //
            control.ControlAdded += m_controlAddedHandler;
            control.ControlRemoved += m_controlRemovedHandler;

            //
            // Use reflection to look for event that will be hooked.
            //
            Type typ = control.GetType();
            EventInfo theEvent = typ.GetEvent(m_eventName);

            theEvent.AddEventHandler(control, m_genericHandler);

            //
            // recursively hook events for nested controls
            //
            foreach (Control subControl in control.Controls)
            {
                HookPrimaryEvents(subControl);
            }
        }

        /// <summary>
        ///     When overridden, returns the delegate used to handled the
        ///     event.
        /// </summary>
        protected abstract Delegate RelayDelegate { get; }

        /// <summary>
        ///     When a control is no longer part of the hierarchy, need to
        ///     remove any event bindings used to watch the control's state.
        /// </summary>
        /// <param name="control">
        ///     Control to remove bindings for.
        /// </param>
        private void UnhookPrimaryEvents(Control control)
        {
            //
            // hook static events.
            //
            control.ControlAdded -= m_controlAddedHandler;
            control.ControlRemoved -= m_controlRemovedHandler;

            //
            // Use reflection to look for event that will be hooked.
            //
            Type typ = control.GetType();
            EventInfo theEvent = typ.GetEvent(m_eventName);
            theEvent.RemoveEventHandler(control, m_genericHandler);

            //
            // recursively hook events for nested controls
            //
            foreach (Control subControl in control.Controls)
            {
                UnhookPrimaryEvents(subControl);
            }
        }

        /// <summary>
        ///     Handler for when a control is added as a child control.
        /// </summary>
        /// <param name="sender">
        ///     The control raising this event.
        /// </param>
        /// <param name="ea">
        ///     The arguments for the added control
        /// </param>
        private void ControlAddedHandler(object sender, ControlEventArgs ea)
        {
            Control control = ea.Control;

            HookPrimaryEvents(control);
        }

        /// <summary>
        ///     Event raised after the relay process has completed.
        /// </summary>
        public event RelayedEventHandler Relayed;

        /// <summary>
        ///     Raises the <see cref="Relayed"/> event.
        /// </summary>
        /// <param name="ea">
        ///     Parameters passed to the event.
        /// </param>
        protected void OnRelayed(RelayedEventArgs ea)
        {
            if (Relayed != null)
            {
                Relayed(this, ea);
            }
        }

        private void ControlRemovedHandler(object sender, ControlEventArgs ea)
        {
            Control control = ea.Control;

            UnhookPrimaryEvents(control);
        }

        /// <summary>
        ///     Unhooks all registered events.
        /// </summary>
        public void Dispose()
        {
            UnhookPrimaryEvents(m_control);
            GC.SuppressFinalize(this);
        }

        ~EventBroadcastProvider()
        {
            Dispose();
        }

        private Control m_control = null;
        private List<Control> m_chain = null;
        private string m_eventName = String.Empty;
        private const string EventMethodTemplate = "On{0}";
        private bool m_noReentry = false;
        ControlEventHandler m_controlAddedHandler = null;
        ControlEventHandler m_controlRemovedHandler = null;
        Delegate m_genericHandler = null;
    }

    /// <summary>
    ///     Parameters passed to the <see cref="EventBroadcastProvider"/> 
    ///     event.
    /// </summary>
    public class RelayedEventArgs
    {
        /// <summary>
        ///     Initializes a new instance.
        /// </summary>
        /// <param name="controls">
        ///     Lists of controls affected by the relay.  Each of these received the
        ///     targetted event invocation.
        /// </param>
        public RelayedEventArgs(Control[] controls)
        {
            m_controls = controls;
        }

        /// <summary>
        ///     Controls affected by the relay.  Each of these received the
        ///     targetted event invocation.
        /// </summary>
        public Control[] RelayChain
        {
            get
            {
                return m_controls;
            }
        }

        private Control[] m_controls = null;
    }

    public delegate void RelayedEventHandler(object sender, RelayedEventArgs ea);
}
