using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectcBackend.Models;

namespace projectcBackend.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class UserControllerV1 : ControllerBase
    {
        // GET: api/v1/users
        [HttpGet("users")]
        //public async Task<List<User>> GetAsync()
        public List<User> Get()
        {   
            LinkModel twitchLink = new LinkModel { LinkType = LinkTypes.Twitch, Url = "www.twitch.tv" };

            User user = new User {
                Username = "username1",
                MemberRole = MemberRoles.Member,
                Email = "username1@user.com",
                About = "This is the about of the username1.",
                LinkList = new List<LinkModel>{ twitchLink },
                IsAdmin = false,
                AdminId = ""
            };

            List<User> usersList = new List<User>{ user };

            // User usersList = await // add method here

            return usersList;
        }

        // GET: api/v1/users/{username}
        // public async Task<User> GetAsync(string username)git
        public User Get(string username)
        {
            LinkModel twitchLink = new LinkModel { LinkType = LinkTypes.Twitch, Url = "www.twitch.tv" };

            User user = new User {
                Username = "username1",
                MemberRole = MemberRoles.Member,
                Email = "username1@user.com",
                About = "This is the about of the username1.",
                LinkList = new List<LinkModel>{ twitchLink },
                IsAdmin = false,
                AdminId = ""
            };

            return user;
        }
    }
}
