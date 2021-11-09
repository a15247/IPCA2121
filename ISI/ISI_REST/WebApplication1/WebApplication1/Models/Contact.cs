using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Contact
    {
        public enum ContactType { Email, Phone, Other}

        public ContactType contactType { get; set; }

        public object Value { get; set; }
    }
}
