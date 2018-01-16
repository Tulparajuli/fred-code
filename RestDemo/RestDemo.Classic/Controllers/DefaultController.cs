using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestDemo.Classic.Controllers
{
  public class DefaultController : ApiController
  {
    
    public string GetA(int id)
    {
      return "hello web api classic A";
    }

    public string GetV()
    {
      return "hello web api classic V";
    }
  }
}
