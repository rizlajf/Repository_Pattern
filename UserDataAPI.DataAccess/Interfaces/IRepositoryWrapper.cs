using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IRoleRepository Role { get; }
    }
}
