using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar.Repository.Shared.Abstract;

namespace Tekrar.Repository.Shared.Concrete.config
{
    public static class Config
    {
        public static void RepoDı(this IServiceCollection services)
        {
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
              services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


        }
        public static void lower(this string name) { 
        //adsfasdfadf
        //adsfasdfadf
        }
    }
}
