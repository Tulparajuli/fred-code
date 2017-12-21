using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Mvc.Models
{
  public class Person
  {
    [Required(ErrorMessage = "Connor said so...")]
    [StringLength(50)]
    [DataType(DataType.Text)]
    [Display(Name = "First Name")]
    public string GivenName { get; set; }

    [StringLength(50)]
    public string FamilyName { get; set; }
    //public List<Person> People { get; set; }
    //public Address MyProperty { get; set; }
  }
}