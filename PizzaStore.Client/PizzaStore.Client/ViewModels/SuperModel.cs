using PizzaStore.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Client.ViewModels
{
  public class SuperModel
  {
    public List<Pizza> Pizzas { get; set; }

    public SuperModel()
    {
      Pizzas = GetPizzas();
    }

    private List<Pizza> GetPizzas()
    {
      return new List<Pizza>()
      {
        new Pizza(),
        new Pizza(),
        new Pizza()
      };
    }
  }
}
