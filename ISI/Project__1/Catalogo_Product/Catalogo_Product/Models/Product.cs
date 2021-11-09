using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Product.Models
{
    public class Product
    {

        public int Code { get; set; }

        public String Description { get; set; }

        public float Price { get; set; }

        public bool Available { get; set; }


    }
}
