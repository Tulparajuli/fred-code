namespace AdventureWorks.AdoData
{
  public class Customer
  {
    public string Fname { get; set; }
    public string Lname { get; set; }

    public Customer(string f, string l)
    {
      Fname = f;
      Lname = l;
    }
  }
}