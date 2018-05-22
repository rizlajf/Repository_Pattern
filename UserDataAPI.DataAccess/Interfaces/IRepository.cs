using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> FindAll(string query);
        TEntity FindById(string query, int id);
        TEntity FindByName(string query, string name);
        IList<TEntity> FindTheListById(string query, int id);
    }
}
