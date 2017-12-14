using AdventureWorks.EfData;
using System;

namespace AdventureWorks.EfConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var ef = new EfHelper();

      //ef.GetCustomers();
      ef.GetCustomers2();
      Console.ReadLine();
    }
  }
}
