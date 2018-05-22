using UserDataAPI.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IConfiguration _configuration;
        private IUserRepository _user;
        private IRoleRepository _role;

        // FOR EF
        //private UserRoleDataContext _repoContext;        

        //public new IUserRepository User
        //{
        //    get
        //    {
        //        if (_user == null)
        //        {
        //            _user = new UserRepository(_repoContext);
        //        }

        //        return _user;
        //    }
        //}

        //public new IRoleRepository Role
        //{
        //    get
        //    {
        //        if (_role == null)
        //        {
        //            _role = new RoleRepository(_repoContext);
        //        }

        //        return _role;
        //    }
        //}

        //public RepositoryWrapper(UserRoleDataContext repositoryContext)
        //{
        //    _repoContext = repositoryContext;
        //}

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_configuration);
                }

                return _user;
            }
        }

        public IRoleRepository Role
        {
            get
            {
                if (_role == null)
                {
                    _role = new RoleRepository(_configuration);
                }

                return _role;
            }
        }
        public RepositoryWrapper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
