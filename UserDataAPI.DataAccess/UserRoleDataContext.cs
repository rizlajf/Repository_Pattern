using UserDataAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess
{
    public class UserRoleDataContext : DbContext
    {
        public UserRoleDataContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
