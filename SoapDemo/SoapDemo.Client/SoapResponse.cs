using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapDemo.Client
{
  [DataContract]
  public class SoapResponse
  {
    [DataMember(Name = "Message")]
    public string Response { get; set; }

    [DataMember]
    public bool Error { get; set; }
  }
}
