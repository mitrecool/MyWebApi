using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Db;
using MyWebApi.Db.Repository;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/values")]
    [ApiController]
    public class ValuesV2Controller : ControllerBase
    {
        private readonly IDataRepository<Pet> _petRepository;
        private readonly IDataRepository<Good> _goodRepository;

        public ValuesV2Controller(IDataRepository<Pet> petRepository, IDataRepository<Good> goodRepository)
        {
            _petRepository = petRepository;
            _goodRepository = goodRepository;
        }

        [HttpGet]
        [Route("retrieveGoods")]
        public async Task<ActionResult<IEnumerable<Good>>> RetrieveGoods()
        {
            try
            {
                return Ok(await _goodRepository.GetAllAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("retrievePets")]
        public async Task<ActionResult<IEnumerable<Pet>>> RetrievePets()
        {
            try
            {
                return Ok(await _petRepository.GetAllAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("retrievePet")]
        public async Task<ActionResult<Pet>> RetrievePet(Guid id)
        {
            try
            {
                return Ok(await _petRepository.GetAsync(id));
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("createPet")]
        public async Task<IActionResult> CreatePet(Pet pet)
        {
            try
            {
                await _petRepository.AddAsync(pet);

                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}