using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Client.Models
{
  public class Pizza
  {
    public string Name { get; set; }
    public List<Topping> Toppings { get; set; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }
  }
}
