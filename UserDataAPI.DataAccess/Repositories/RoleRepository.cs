using UserDataAPI.DataAccess.Entities;
using UserDataAPI.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(IConfiguration configuration)
            : base(configuration)
        {
        }

        public Role GetRoleById(int id)
        {
            string query = string.Format("SELECT * FROM Roles where RoleId = @Id");
            Role role = FindById(query, id);
            return role;
        }

        public IList<Role> GetRoles()
        {
            string query = "SELECT * FROM Roles";
            IList<Role> roleList = FindAll(query);
            return roleList;
        }

        public Role GetRoleByName(string name)
        {
            string query = string.Format("SELECT * FROM Roles where RoleName = @Name");
            Role role = FindByName(query, name);
            return role;
        }
    }
}
