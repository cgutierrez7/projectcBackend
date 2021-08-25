using System;
using System.Collections.Generic;

namespace projectcBackend
{
    public class User
    {
        public string Username { get; set; }
        public MemberRoles MemberRole { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public List<LinkModel> LinkList { get; set; }
        public bool IsAdmin { get; set; }
        public string AdminId { get; set; }
    }
}

