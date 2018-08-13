using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PostStar.Communicator.DataStructure
{
    /// <summary>
    /// 사용자 정보
    /// </summary>
    public class Member
    {
        public String nickName { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public IPAddress iPAddress { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nickName"></param>
        public Member(String nickName)
        {
            this.nickName = nickName;
            this.iPAddress = IPAddress.Parse("127.0.0.1");
        }
    }
}
