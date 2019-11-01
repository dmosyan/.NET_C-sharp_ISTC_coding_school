using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Common middlewares
            // Authentication: Login, password
            // Response Cashing: saveing answers
            // Response Compression: zip ing answers from server for example gzip
            // Routing: 
            // Static File: JS code, CSS

            // Every middleware is createing only once then .NET is using previous information

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Authentication middleware
            app.UseAuthentication();

            // Static files: CSS, JS etc.
            app.UseStaticFiles();

            // installig logic for processing request
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
