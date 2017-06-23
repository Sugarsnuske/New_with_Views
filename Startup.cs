using New_with_Views.Models;
using New_with_Views.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace New_with_Views
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>();
            services.AddMvc();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IInMoviesRepository, InMoviesRepository>();
        }

       public void Configure(IApplicationBuilder app, ILoggerFactory logger, MyDbContext context)
       {
            app.UseStaticFiles();
            logger.AddConsole();
            app.UseMvcWithDefaultRoute();
            DbInitializer.Initialize(context);
       }
    }
}