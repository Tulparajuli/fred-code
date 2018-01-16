using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapPizzaConsumer.Peater.Models
{
  public class RestPizzaPie
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}