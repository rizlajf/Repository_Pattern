using UserDataAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<Users>
    {
        IList<Users> GetUsers();
        Users GetUserById(int Id);
        IList<Users> GetUserByRole(int RoleId);
    }
}
