using Catalogo_Product.Exceptions;
using Catalogo_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalogo_Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        
        private Dictionary<int, Product> products;
        
        public ProductsController()
        {
            this.products = new Dictionary<int, Product>
            {
                { 1001, new Product{ Code = 1001, Description ="Batatas", Price = 15.45F, Available = true} },
                { 1002, new Product{ Code = 1002, Description ="Laranjas", Price = 65.45F, Available = false} },
                { 1003, new Product{ Code = 1003, Description ="Cenouras", Price = 75.45F, Available = true } },
            };
        }


        // GET: api/<ProductsController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Dictionary<int, Product>> Get()
        {
            if (this.products.Count.Equals(0))
            {
                return BadRequest("Não tens produtos");
            }
            //return the products
            return Ok(this.products);
        }



        // GET api/<ProductsController>/5
        [HttpGet("{code}")]
        public ActionResult<Product> Get(int code)
        {
            try
            {
                if(this.products.Count(p => p.Key.Equals(code)).Equals(0))
                {
                    throw new ProductNotFound();
                }
                return Ok(this.products.FirstOrDefault(p => p.Key.Equals(code)));
            }
            catch (ProductNotFound ex)
            {

                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }            
        }
        [HttpGet("Count")]

        public ActionResult<int> Count()
        {
            return Ok(this.products.Count);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                //garantir que o novo produto não existe
                if (this.products.Count(p => p.Key.Equals(product.Code)).Equals(0))
                {
                    throw new ProductAlreadyExists();
                }
                //ADD PRODUCT
                this.products.Add(product.Code, product);

                return CreatedAtAction(nameof(Get),
                    new { product.Code },
                    this.products.FirstOrDefault(p => p.Key.Equals(product.Code))
                    );
            }
            catch (ProductNotFound ex)
            {

                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
