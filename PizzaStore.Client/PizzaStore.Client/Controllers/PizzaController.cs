using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using PizzaStore.Client.Models;
using PizzaStore.Client.ViewModels;

namespace PizzaStore.Client.Controllers
{
  public class PizzaController : Controller
  {
    private static SuperModel _SM = new SuperModel();

    // GET: Pizza
    public ActionResult Index()
    {
      return View(_SM.GetPizzas());
    }

    // GET: Pizza/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: Pizza/Create
    public ActionResult Create()
    {
      return View(new Pizza());
    }

    // POST: Pizza/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Pizza p)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          throw new ArgumentException("this pizza eh no good!!!");
        }

        _SM.AddPizza(p);
        return RedirectToAction(nameof(Index));
      }
      catch
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
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction(nameof(Index));
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
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}