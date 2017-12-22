using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.DataAccess.Models
{
  public class Pizza
  {
    public int PizzaId { get; set; }
    public string Name { get; set; }
    public DateTime DateModified { get; set; }
    public bool? Active { get; set; }
  }
}
