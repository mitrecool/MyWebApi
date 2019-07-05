using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/values")]
    [ApiController]
    public class ValuesV2Controller : ControllerBase
    {        
        [HttpGet]
        [Route("retrieveGoods")]
        public ActionResult<IEnumerable<Good>> RetrieveGoods()
        {
            return new Good[] 
            {
                new Good() { Name = "Soccer ball",  Description = "New soccer ball", Price = 111.0m },
                new Good() { Name = "Foot ball",  Description = "New foot ball", Price = 111.0m },
            };
        }

        [HttpGet]
        [Route("retrievePets")]
        public ActionResult<IEnumerable<Pets>> RetrievePets()
        {
            return new Pets[]
            {
                new Pets() { Name = "Cat",  Description = "Cute cat", Price = 111.0m },
                new Pets() { Name = "Dog",  Description = "Good boy", Price = 111.0m },
            };
        }
    }
}