using SoapPizza.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapPizza.Service
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPizzaService" in both code and config file together.
  [ServiceContract]
  public interface IPizzaService
  {
    [OperationContract]
    List<PizzaPie> OrderPizza(string name, int quantity);

    [OperationContract(Action = "OrderPizzaNew")]
    List<PizzaPie> OrderPizza(string name, int quantity, decimal price);

    //bool PayPizza(decimal payment);
  }
}
