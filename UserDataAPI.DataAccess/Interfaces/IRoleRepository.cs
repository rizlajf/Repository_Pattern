using UserDataAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        IList<Role> GetRoles();
        Role GetRoleById(int Id);
        Role GetRoleByName(string name);
    }
}
