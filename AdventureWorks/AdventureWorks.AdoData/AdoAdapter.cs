using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventureWorks.AdoData
{
  public class AdoAdapter
  {
    private string ConnectionString = "data source=fredsqlweek.database.windows.net;initial catalog=fredsqlweek;user id=sqladmin;password=Password123;";
    private List<Customer> customers = new List<Customer>();

    public List<Customer> GetCustomers()
    {
      string query = "select firstname, lastname from SalesLT.Customer;";
      SqlCommand cmd = new SqlCommand(query);
      SqlDataAdapter da = new SqlDataAdapter();

      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        DataSet ds = new DataSet();

        con.Open();
        cmd.Connection = con;
        da.SelectCommand = cmd;
        da.Fill(ds);

        foreach(DataRow r in ds.Tables[0].Rows)
        {
          var c = new Customer(r[0].ToString(), r[1].ToString());
          customers.Add(c);
          System.Console.WriteLine(c.Fname + " " + c.Lname);
        }
      }

      return customers;
    }
  }
}
