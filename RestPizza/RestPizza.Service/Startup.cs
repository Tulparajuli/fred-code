using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace RestPizza.Service
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddCors(
        c => {
          c.AddPolicy("Restricted", p => p.WithOrigins("http://example.com").WithMethods("GET"));
          c.AddPolicy("Open", p => p.AllowAnyOrigin().AllowAnyMethod());
        }
      );
      services.AddAuthentication("PizzaCookie").AddCookie("PizzaCookie",
        c =>
        {
          c.LoginPath = "/api/account/signin";
          c.LogoutPath = "/api/account/signout";
          c.Cookie = new CookieBuilder()
          {
            HttpOnly = true,
            Name = "Phillip",
            SameSite = SameSiteMode.Strict
          };
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      //app.UseCors();
      app.UseAuthentication();
      app.UseMvc();
    }
  }
}
