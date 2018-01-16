using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapPizza.Library
{
  public class PizzaMaker
  {
    public static PizzaPie MakePizza(string name)
    {
      return new PizzaPie()
      {
        Id = DateTime.Now.Ticks,
        Name = name,
        Price = 9.99M
      };
    }
  }
}
