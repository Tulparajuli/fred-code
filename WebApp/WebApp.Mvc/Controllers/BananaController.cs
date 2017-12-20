using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Mvc.Filters;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Controllers
{
  public class BananaController : Controller
  {
    // GET: Banana
    //public ActionResult Index()
    //{
    //  var p = new Person() { Name = "fred" };
    //  ViewBag.Data = "nada";
    //  ViewData["Data"] = "niet";

    //  TempData["Data"] = "fred";
    //  Session["Data"] = "belotte";

    //  return RedirectToAction("Default");
    //  //return View(p);
    //}

    //[HttpPost]
    //[HttpGet]
    //[CustomValidation]
    //[Authorize]
    //public ActionResult Default(string id)
    //{
    //  if (ModelState.IsValid)
    //  {
    //    var p = new Person() { Name = "class" };
    //    return View("Index", p);
    //  }

    //  return View("Index", null);
    //}

    //[HttpGet]
    //[CustomException]
    //public ActionResult Default()
    //{
    //  var p = new Person() { Name = "class" };
    //  return View("Index", p);
    //}

    [HttpPost]
    public ActionResult Validate(Person p)
    {
      if (ModelState.IsValid)
      {
        return View("Success");
      }

      return View("Failure");
    }

    [HttpGet]
    public ActionResult Validate()
    {
      return View();
    }
  }
}