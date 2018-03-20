using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetcoreSignalRSever;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetcoreSignalRSever
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddCors(options =>
            {
                options.AddPolicy("fiver",
                    policy => policy.AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod());
            });

            services.AddSignalR(); // <-- SignalR

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("fiver");

            app.UseSignalR(routes =>  // <-- SignalR
            {
                routes.MapHub<ReportsPublisher>("reportsPublisher");
            });

        }
    }
}
