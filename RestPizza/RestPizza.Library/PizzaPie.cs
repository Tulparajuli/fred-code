using System;
using System.Collections.Generic;
using System.Text;

namespace RestPizza.Library
{
  public class PizzaPie
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public PizzaPie()
    {

    }

    public PizzaPie(string name, decimal price = 9.99M)
    {
      Id = DateTime.Now.Ticks;
      Name = name;
      Price = price;
    }
  }
}
