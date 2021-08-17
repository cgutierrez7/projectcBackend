using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace projectcBackend.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class UserControllerV1 : ControllerBase
    {
        // GET: api/v1/users
        [HttpGet("users")]
        public User Get()
        {   
            var users = new User{
                Username = "username1",
                IsMember = true,
                MemberType = "member",
                Email = "username1@user.com",
                About = "This is the about of the username1."
            };

            return users;
        }
    }
}
