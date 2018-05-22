using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
    }
}
