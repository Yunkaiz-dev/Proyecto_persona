using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Proyecto_persona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            string result = "Estoy retornando un Post";
            return Ok(result);
        }
        [HttpGet]
        public IActionResult Index()
        {
            string result = "Estoy retornando un Get";
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            string result = "Estoy retornando un Delete";
            return Ok(result);
        }
        [HttpPatch]
        public IActionResult Update()
        {
            string result = "Estoy retornando un Patch";
            return Ok(result);
        }
    }
}
