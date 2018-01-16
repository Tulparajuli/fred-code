using SoapDemo.Console.PizzaReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SoapDemo.Console
{
  class Program
  {
    static void Main(string[] args)
    {
      var client = new PizzaClient();
      var tc = Transaction.Current;

      using (var t = new TransactionScope(tc))
      {
        try
        {
          client.Prepare();
          //client.Bake();
          //client.Deliver();
          t.Complete();
        }
        catch (Exception)
        {
          t.Dispose();
        }
      }

      System.Console.WriteLine(client.Prepare().Message);
      System.Console.ReadLine();
    }
  }
}
