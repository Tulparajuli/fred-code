using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.EfData
{
  public class EfHelper
  {
    private fredsqlweekContext db = new fredsqlweekContext();

    public void GetCustomers()
    {
      foreach (var item in db.Customer.ToList())
      {
        Console.WriteLine(item.FirstName + " " + item.LastName);
      }
    }

    public void GetCustomers2()
    {
      var query = (from a in db.Address
                  select new { a.AddressLine1, a.City }).ToList();

      db.Address.Add(new Address
      {
        AddressLine1 = "11740 plaza america dr",
        City = "reston",
        CountryRegion = "usa",
        PostalCode = "20190",
        StateProvince = "virginia"
      });

      db.SaveChanges();

      foreach (var item in query)
      {
        Console.WriteLine(item.AddressLine1 + " " + item.City);
      }
    }
  }
}
