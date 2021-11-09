using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Product.Exceptions
{
    public class ProductNotFound : Exception
    {
        public override string Message => "Product does not exists";
    }
}
