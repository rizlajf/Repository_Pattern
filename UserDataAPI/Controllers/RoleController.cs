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
    [Route("api/Roles")]
    public class RolesController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public RolesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        // GET api/Roles
        [HttpGet]
        public IList<Role> GetRoles()
        {
            IList<Role> roleList = _repoWrapper.Role.GetRoles().ToList();
            return roleList;
        }

        // GET api/Roles/5
        [HttpGet("{id}")]
        public Role GetRoleById(int id)
        {
            Role role = _repoWrapper.Role.GetRoleById(id);
            return role;
        }

        // GET api/Roles/JVP_User
        [HttpGet("{role}")]
        public Role GetRoleByName(string role)
        {
            Role roleByName = _repoWrapper.Role.GetRoleByName(role);
            return roleByName;
        }
    }
}