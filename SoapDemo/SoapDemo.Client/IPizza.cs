using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapDemo.Client
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPizza" in both code and config file together.
  [ServiceContract]
  public interface IPizza
  {
    //[OperationBehavior(TransactionScopeRequired = true)]
    [OperationContract]
    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "prepare")]
    SoapResponse Prepare();

    [OperationContract]
    [WebInvoke(Method = "Post")]
    void Bake();

    void Deliver();
  }
}
