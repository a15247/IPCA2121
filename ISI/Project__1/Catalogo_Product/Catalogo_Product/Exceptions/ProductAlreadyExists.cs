using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Product.Exceptions
{
    public class ProductAlreadyExists : Exception
    {
        public override string Message => "Product already exists";
    }
}
