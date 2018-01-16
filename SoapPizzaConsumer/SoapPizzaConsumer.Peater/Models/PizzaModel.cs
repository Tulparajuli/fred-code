//using SoapPizza.Library;
using SoapPizzaConsumer.Peater.PizzaReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace SoapPizzaConsumer.Peater.Models
{
  public class PizzaModel
  {
    public List<PizzaReference.PizzaPie> Pies { get; private set; }
    public List<RestPizzaPie> RestPies { get; private set; }

    public PizzaModel()
    {
      Pies = new List<PizzaReference.PizzaPie>();
      RestPies = new List<RestPizzaPie>();
    }

    //public void ProjectReference()
    //{
    //  var p = PizzaMaker.MakePizza("hawaiian");
    //}

    public void ServiceReference()
    {
      var svc = new PizzaServiceClient();

      Pies = svc.OrderPizza("hawaiian", 0).ToList();
    }

    public bool Create(string name)
    {
      var svc = new PizzaServiceClient();
      var count = Pies.Count;

      Pies.AddRange(svc.OrderPizza(name, 1).ToList());

      return Pies.Count > count;
    }

    public List<PizzaReference.PizzaPie> List()
    {
      return Pies;
    }

    public bool RestCreate(string name)
    {
      var svc = new HttpClient();
      //svc.DefaultRequestHeaders.Accept.Add("Content-Type", "application/json");
      var content = JsonConvert.SerializeObject(new { Name = name });

      var res = svc.PostAsync("http://localhost/restpizza/api/pizza", 
        new StringContent(content, Encoding.UTF8 ,"application/json")).GetAwaiter().GetResult();

      return res.IsSuccessStatusCode;
    }

    public List<RestPizzaPie> RestList()
    {
      var svc = new HttpClient();
      var res = svc.GetAsync("http://localhost/restpizza/api/pizza").GetAwaiter().GetResult();

      if (res.IsSuccessStatusCode)
      {
        RestPies = JsonConvert.DeserializeObject<List<RestPizzaPie>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        return RestPies;
      }

      return RestPies;
    }
  }
}