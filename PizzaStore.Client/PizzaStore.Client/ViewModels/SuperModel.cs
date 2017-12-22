using PizzaStore.Client.Models;
using Lib = PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Client.ViewModels
{
  public class SuperModel
  {
    private static List<Pizza> _Pizzas = new List<Pizza>();
    private Lib.LibHelper _LH = Lib.LibHelper.Instance();

    public List<Pizza> GetPizzas()
    {
      return PizzaToClient(_LH.GetPizza());
    }

    public void AddPizza(Pizza p)
    {
      _LH.AddPizza(PizzaToLibrary(new List<Pizza>() { p }).FirstOrDefault());
    }

    private List<Pizza> PizzaToClient(List<Lib.Pizza> ps)
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

    private List<Lib.Pizza> PizzaToLibrary(List<Pizza> ps)
    {
      var ls = new List<Lib.Pizza>();

      foreach (var item in ps)
      {
        ls.Add(new Lib.Pizza()
        {
          Name = item.Name
        });
      }

      return ls;
    }
  }
}
