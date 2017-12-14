using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventureWorks.AdoData
{
  public class AdoReader
  {
    private string ConnectionString = "data source=fredsqlweek.database.windows.net;initial catalog=fredsqlweek;user id=sqladmin;password=Password123;";
    private List<Customer> customers = new List<Customer>();

    public List<Customer> GetCustomers()
    {
      string query = "select firstname, lastname from SalesLT.Customer;";
      SqlCommand cmd = new SqlCommand(query);
      SqlDataReader dr;

      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        cmd.Connection = con;
        dr = cmd.ExecuteReader();

        while(dr.Read())
        {
          var c = new Customer(dr[0].ToString(), dr[1].ToString());
          customers.Add(c);
          System.Console.WriteLine(c.Fname + " " + c.Lname);

          Thread.Sleep(1500);
        }
      }

      return customers;
    }
  }
}
