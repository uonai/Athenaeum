using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;

namespace Athenaeum
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void Configure(IServiceProvider serviceProvider)
        {
            serviceProvider.GetService<MyDbContext>();

        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection") ?? "testingconnection";
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            return services.BuildServiceProvider();
        }
    }
}
