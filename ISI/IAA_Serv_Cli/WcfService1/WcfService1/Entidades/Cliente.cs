using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Entidades
{
    [DataContract]
    public class Cliente
    {
        
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string Nome { get; set; }
    }
}