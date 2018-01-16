using SoapPizzaConsumer.Peater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoapPizzaConsumer.Peater.Controllers
{
  public class PizzaController : Controller
  {
    private static PizzaModel pm = new PizzaModel();

    // GET: Pizza
    public ActionResult Index()
    {
      //return View(pm.List());
      return View(pm.RestList());
    }

    // GET: Pizza/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: Pizza/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Pizza/Create
    [HttpPost]
    public ActionResult Create(PizzaReference.PizzaPie pie)
    {
      try
      {
        if (ModelState.IsValid)
        {
          //pm.Create(pie.Name);
          pm.RestCreate(pie.Name);
        }
        
        return RedirectToAction("Index");
      }
      catch (Exception ex)
      {
        return View();
      }
    }

    // GET: Pizza/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: Pizza/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // GET: Pizza/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: Pizza/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }
  }
}
