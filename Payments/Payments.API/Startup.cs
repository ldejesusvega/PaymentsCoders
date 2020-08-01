using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Payment.Core;
using Payment.Core.Services;
using Payment.Data;
using Payment.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace Payments.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                                options.UseSqlServer(
                                                    Configuration.GetConnectionString("DefaultConnection")
                                                    , x => x.MigrationsAssembly("Payment.Data")
                                                )
                                            );
            services.AddControllers();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddSwaggerGen(options =>
                                    {
                                        options.SwaggerDoc(
                                            "v1",
                                            new OpenApiInfo { Title = "Payments", Version = "v1" });
                                    });
            services.AddAutoMapper(typeof(Startup));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
                            {
                                c.RoutePrefix = "";
                                c.SwaggerEndpoint(
                                    "/swagger/v1/swagger.json",
                                    "My Music V1"
                                    );
                            });
        }
    }
}
