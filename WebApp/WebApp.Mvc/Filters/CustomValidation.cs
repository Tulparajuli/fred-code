using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApp.Mvc.Filters
{
  public class CustomValidation : ValidationAttribute
  {
    public override bool IsValid(object value)
    {
      //return base.IsValid(value);

      return Regex.IsMatch(value.ToString(), "[^a-zA-Z0-9]");
    }
  }
}