using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapDemo.Client
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Pizza" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Pizza.svc or Pizza.svc.cs at the Solution Explorer and start debugging.
  public class Pizza : IPizza
  {
    public void Bake()
    {
      throw new NotImplementedException();
    }

    public void Deliver()
    {
      throw new NotImplementedException();
    }

    public SoapResponse Prepare()
    {
      return new SoapResponse()
      {
        Response = "Connor is tossing the crust...",
        Error = false
      };
    }
  }
}
