using UserDataAPI.DataAccess.Entities;
using UserDataAPI.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Repositories
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
            : base(configuration)
        {
        }

        public IList<Users> GetUsers()
        {
            string query = "SELECT * FROM Users";
            IList<Users> userList = FindAll(query);
            return userList;
        }
        
        public Users GetUserById(int id)
        {

            string query = string.Format("SELECT * FROM Users where UserId = @Id");
            Users user = FindById(query, id);
            return user;
        }

        public IList<Users> GetUserByRole(int roleId)
        {
            string query = string.Format("SELECT * FROM Users where RoleId = @Id");
            IList<Users> userList = FindTheListById(query, roleId);
            return userList;
        }
    }
}
