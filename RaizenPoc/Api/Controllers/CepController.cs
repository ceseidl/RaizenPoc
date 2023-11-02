using Api.Helpers;
using Api.Services;
using Api.Services.Interfaces;
using ConsoleApp1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepServices _cepService;
        public CepController(ICepServices CEPServices)
        {
            _cepService = CEPServices;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("is-alive")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        public bool IsAlive()
        {
            return true;
        }

        [HttpGet()]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [Produces("application/json")]

        public async Task<IActionResult> GetEnderecoAsync([FromQuery]string cep)
        {
            var endereco = await _cepService.GetEndereco(cep);
            if (endereco is null)
            {
                return NotFound();
            }
            if (Extensions.ArePropertiesNotNull(endereco) == false) 
            {
                return NotFound();

            }
            return Ok(endereco);
            
           
        }
    }
}
