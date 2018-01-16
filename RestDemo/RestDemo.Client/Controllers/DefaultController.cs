using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RestDemo.Client.Models;

namespace RestDemo.Client.Controllers
{
  //[Consumes("application/json")]
  //[EnableCors("open")]
  [DisableCors]
  [Produces("application/xml")]
  [Route("api/[controller]")]
  public class DefaultController : Controller
  {
    [HttpGet]
    public string Get(RequestObject blah)
    {
      return "hello Web API 2";
    }

    [HttpGet("{Id}")]
    public int Get(int blah)
    {
      return 10;
    }

    [HttpPost]
    public IActionResult Post([FromBody]RequestObject ro)
    {
      if (ro.Num != 0)
      {
        return Ok(ro);
      }
      else
      {
        return BadRequest("CONNOR, fix it...");
      }
    }
  }
}