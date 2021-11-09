using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {

        public Customer()
        {
            this.contacts = new List<Contact>();
        }


        public int Code { get; set; }


        public string Name { get; set; }

        public List<Contact> contacts { get; set; }
    }
}
