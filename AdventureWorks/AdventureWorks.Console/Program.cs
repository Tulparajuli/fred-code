using AdventureWorks.AdoData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Console
{
  class Program
  {
    static void Main(string[] args)
    {
      //var ador = new AdoReader();
      //ador.GetCustomers();

      var adoa = new AdoAdapter();
      adoa.GetCustomers();
    }
  }
}
