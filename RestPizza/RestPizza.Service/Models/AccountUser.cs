using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPizza.Service.Models
{
  public class AccountUser
  {
    public string Username { get; set; }
    public string Password { get; set; }

    public AccountUser()
    {
      Username = "Raymond";
    }
  }
}
