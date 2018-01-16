using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SoapPizza.Library;

namespace SoapPizza.Service
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PizzaService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select PizzaService.svc or PizzaService.svc.cs at the Solution Explorer and start debugging.
  public class PizzaService : IPizzaService
  {
    public List<PizzaPie> OrderPizza(string name, int quantity)
    {
      var count = 1;
      var pies = new List<PizzaPie>();

      while (count <= quantity)
      {
        pies.Add(PizzaMaker.MakePizza(name));
        count += 1;
      }

      return pies;
    }

    public List<PizzaPie> OrderPizza(string name, int quantity, decimal price)
    {
      throw new NotImplementedException();
    }
  }
}
