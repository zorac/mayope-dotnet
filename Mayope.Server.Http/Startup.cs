using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Mayope.Api;
using Mayope.Auth;
using Mayope.Auth.Mock;
using Mayope.Data;
using Mayope.Data.Mock;
using Mayope.Meta;
using Mayope.Meta.Mock;
using Mayope.Server.Http.Filters;

namespace Mayope.Server.Http
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataService,MockDataService>();
            services.AddSingleton<IAuthService,MockAuthService>();
            services.AddSingleton<IMetaService,MockMetaService>();
            services.AddSingleton<IMayopeService,MayopeServer>();

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ExceptionFilter));
                options.Filters.Add(typeof(ValidationFilter));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
