using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestPizza.Library;

namespace RestPizza.Service.Controllers
{
  [Authorize]
  [EnableCors("Open")]
  [Produces("application/json")]
  [Route("api/[controller]")]
  public class PizzaController : Controller
  {
    private static List<PizzaPie> _pies = new List<PizzaPie>();

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_pies);
    }

    [EnableCors("Restricted")]
    [HttpPost]
    public IActionResult Post([FromBody]PizzaPie pie)
    {
      try
      {
        _pies.Add(new PizzaPie(pie.Name));
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}