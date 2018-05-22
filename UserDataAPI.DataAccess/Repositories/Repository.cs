using UserDataAPI.DataAccess.Entities;
using UserDataAPI.DataAccess.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace UserDataAPI.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IConfiguration _configuration { get; set; }
        protected string connectionString { get; set; }

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetSection("ConnectionStrings").GetSection("RefDatabaseConnection").Value;
        }
        public IList<TEntity> FindAll(string query)
        {
            IList<TEntity> entityList = new List<TEntity>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    entityList = con.Query<TEntity>(query).AsList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return entityList;
            }
        }

        public TEntity FindById(string query, int id)
        {
            TEntity entity = null;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    entity = con.Query<TEntity>(query, new { Id = id }).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return entity;
            }
        }

        public TEntity FindByName(string query, string name)
        {
            TEntity entity = null;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    entity = con.Query<TEntity>(query, new { Name = name }).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return entity;
            }
        }

        public IList<TEntity> FindTheListById(string query, int id)
        {
            IList<TEntity> entityList = new List<TEntity>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    entityList = con.Query<TEntity>(query, new { Id = id }).AsList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return entityList;
            }
        }
    }
}
