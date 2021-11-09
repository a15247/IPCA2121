using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private List<Customer> customers;

        public CustomersController()
        {
            this.customers = new List<Customer> 
            {
                new Customer { Code = 1, Name = "Joao", contacts =
                    {
                        new Contact {contactType = Contact.ContactType.Email, Value = "fafafa@fafafa.pt"},
                        new Contact {contactType = Contact.ContactType.Phone, Value = "92499419"},
                        new Contact {contactType = Contact.ContactType.Other, Value = 4.4f},
                        new Contact {contactType = Contact.ContactType.Other, Value = true}
                    }
                },
                new Customer { Code = 2, Name = "Maria" }
            };
        }
        
                
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(this.customers);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            if (!this.customers.Exists(c => c.Code.Equals(id)))
                return NoContent();
            return Ok(this.customers.FirstOrDefault(c => c.Code.Equals(id)));
        }

    }
}
