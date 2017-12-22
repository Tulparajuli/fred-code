using PizzaStore.DataAccess;
using Dac = PizzaStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaStore.Library.Models
{
  public class LibHelper
  {
    private static LibHelper _LH;
    private static PizzaStoreDbContext _DB = new PizzaStoreDbContext();

    private LibHelper()
    {

    }

    public static LibHelper Instance()
    {
      if (_LH == null)
      {
        _LH = new LibHelper();
      }

      return _LH;
    }

    public bool AddPizza(Pizza p)
    {
      try
      {
        if (p == null)
        {
          return false;
        }

        var ps = PizzaToDataAccess(new List<Pizza>() { p }).FirstOrDefault();

        _DB.Pizzas.Add(ps);
        _DB.SaveChanges();
      }
      catch (Exception ex)
      {
        return false;
      }

      return true;
    }

    public List<Pizza> GetPizza(Pizza p = null)
    {
      if (p == null)
      {
        return PizzaToLibrary(_DB.Pizzas.ToList());
      }

      return PizzaToLibrary(_DB.Pizzas.ToList()).FindAll(i => i.Name == p.Name);
    }

    private List<Pizza> PizzaToLibrary(List<Dac.Pizza> ps)
    {
      var ls = new List<Pizza>();

      foreach (var item in ps)
      {
        ls.Add(new Pizza()
        {
          Name = item.Name
        });
      }

      return ls;
    }

    private List<Dac.Pizza> PizzaToDataAccess(List<Pizza> ps)
    {
      var ls = new List<Dac.Pizza>();

      foreach (var item in ps)
      {
        ls.Add(new Dac.Pizza()
        {
          Name = item.Name,
          DateModified = DateTime.Now,
          Active = true
        });
      }

      return ls;
    }
  }
}
