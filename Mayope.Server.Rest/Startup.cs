using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Mayope.Auth;
using Mayope.Auth.Mock;
using Mayope.Data;
using Mayope.Data.Mock;
using Mayope.Server.Rest.Filters;

namespace Mayope.Server.Rest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataProvider,MockDataProvider>();
            services.AddSingleton<IAuthProvider,MockAuthProvider>();
            services.AddSingleton<IServer,MayopeServer>();
            services.AddScoped<IAuth,StandardAuth>();
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ExceptionFilter));
                options.Filters.Add(typeof(ValidationFilter));
                options.Filters.Add(typeof(AuthFilter));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
