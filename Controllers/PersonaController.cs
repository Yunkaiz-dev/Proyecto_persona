using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Proyecto_persona.Abstraccion.Servicios;
using Proyecto_persona.DTO;
using Proyecto_persona.Implementaciones.Servicios;
using System.Runtime.CompilerServices;

namespace Proyecto_persona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IServicioPersona service;
        public PersonaController(IServicioPersona Servicio)
        {
            service = Servicio;
            
        }

        [HttpPost]
        public IActionResult Create(CrearPersonaDTO persona)
        { 
            var result = service.Create(persona);
            return Ok(result);
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = service.Get(); 
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarPersonaDTO Persona)
        {
            var result = service.Update(id,Persona);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = service.GetById(id);
            return Ok(result);
        }
    }
}
