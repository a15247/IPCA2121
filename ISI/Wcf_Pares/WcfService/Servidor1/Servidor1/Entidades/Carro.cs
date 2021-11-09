using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servidor1.Entidades
{
    [DataContract]
    public class Carro
    {
        [DataMember]
        public int Codigo { get; set }

        [DataMember]
        public string Marca { get; set }

        [DataMember]
        public string Matricula { get; set }

        [DataMember]
        public float Price { get; set }

        [DataMember]
        public float Kms { get; set }

        [DataMember]
        public int Ano_Carro { get; set }






    }
}