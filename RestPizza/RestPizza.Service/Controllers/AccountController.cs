using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestPizza.Service.Models;

namespace RestPizza.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]/[action]")]
  public class AccountController : Controller
  {
    [HttpGet]
    public async Task<IActionResult> Signin(AccountUser user)
    {
      var req = Request.HttpContext;
      var claims = new List<Claim>()
      {
        new Claim(ClaimTypes.Name, user.Username)
      };

      var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

      await req.SignInAsync("PizzaCookie", new ClaimsPrincipal(identity), new AuthenticationProperties()
      {
        IsPersistent = true,
        ExpiresUtc = new DateTimeOffset(DateTime.UtcNow.AddHours(1))
      });

      return Ok();
    }

    [Authorize]
    [HttpGet]
    public IActionResult Signout()
    {
      return Ok(HttpContext.SignOutAsync("PizzaCookie"));
    }
  }
}