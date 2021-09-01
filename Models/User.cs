using System;
using System.Collections.Generic;

namespace projectcBackend.Models
{
    public class User
    {
        public string Username { get; set; }
        public string MemberRole { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public List<LinkModel> LinkList { get; set; }
        public bool IsAdmin { get; set; }
        public string AdminId { get; set; }
    }
}

