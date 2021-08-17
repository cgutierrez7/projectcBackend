using System;
using System.Collections.Generic;

namespace projectcBackend
{
    public class User
    {
        public string Username { get; set; }
        public bool IsMember { get; set; }
        public string MemberType { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public List<LinkModel> LinkList { get; set; }
    }
}

