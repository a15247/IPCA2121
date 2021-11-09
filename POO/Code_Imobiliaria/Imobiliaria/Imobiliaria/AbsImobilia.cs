using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{

    public abstract class AbsImobilia
    {
        int codImobiliario;

        public int codImobiliario 
        { 
            set { codImobiliario = value; }
        }

        public abstract int GetCodeImobiliario();
    }
}
