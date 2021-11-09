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
    public class LandingController : ControllerBase
    {
        // GET: api/<LandingController>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<string> Get()
        {
            return Ok("Everything is goood");
        }



        
    }
}
