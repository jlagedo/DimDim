using DimDim.Infra.Data;
using DimDim.Infra.Repositories;
using DimDim.Model.Repositories;
using DimDim.Model.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DimDim.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DimDimDbContext>(
                options => options.UseSqlServer(
                        "Server=(localdb)\\mssqllocaldb;Database=DimDim;Trusted_Connection=True;MultipleActiveResultSets=true",
                        b => b.MigrationsAssembly("DimDim.Web") 
                    )
                );
            services.AddScoped<IDespesaService, DespesaService>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();
           
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();

        }
    }
}
