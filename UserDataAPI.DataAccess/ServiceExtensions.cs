using UserDataAPI.DataAccess.Interfaces;
using UserDataAPI.DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataAPI.DataAccess
{
    public static class ServiceExtensions
    {
        //public static IConfiguration Configuration { get; }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services, IConfiguration configuration)
        {
            if(configuration != null)
                // FOR EF
                //services.AddDbContext<UserRoleDataContext>(options => options.UseSqlServer(configuration.GetConnectionString("RefDatabaseConnection")));

            services.AddSingleton<IConfiguration>(configuration);
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
