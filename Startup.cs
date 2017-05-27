using New_with_Views.Models;
using New_with_Views.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace New_with_Views
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection servises)
        {
            servises.AddDbContext<MyDbContext>();
            servises.AddMvc();
            servises.AddScoped<IMovieRepository, MovieRepository>();
        }

       public void Configure(IApplicationBuilder app, ILoggerFactory logger, MyDbContext context) // 1. add a context parameter
       {
            app.UseStaticFiles();
            // Log to the Console
            logger.AddConsole();
            app.UseMvcWithDefaultRoute();
            DbInitializer.Initialize(context);
       }
    }
}