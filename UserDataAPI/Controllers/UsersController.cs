using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDataAPI.DataAccess.Entities;
using UserDataAPI.DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserDataAPI.Controllers
{
    //[Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public UsersController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        // GET api/Users
        [HttpGet]
        public IList<Users> Get()
        {
            IList<Users> userList = _repoWrapper.User.GetUsers().ToList();
            return userList;
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public Users GetUserById(int id)
        {
            Users user = _repoWrapper.User.GetUserById(id);
            return user;
        }

        [HttpGet("role/{role}")]
        public IList<Users> GetUserByRole(string role)
        {
            Role userRole = _repoWrapper.Role.GetRoleByName(role);
            IList<Users> user = _repoWrapper.User.GetUserByRole(userRole.RoleId);
            return user;
        }
    }
}