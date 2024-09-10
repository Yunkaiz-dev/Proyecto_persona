using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_persona.DTO;
using Proyecto_persona.Models;

namespace Proyecto_persona.Abstraccion.Servicios
{
    
    public interface IServicioPersona
    {
        List<PersonaDTO> Get();

        Persona GetById(int id);

        PersonaDTO Create(CrearPersonaDTO crearPersonaDTO);

        PersonaDTO Update(int id, ActualizarPersonaDTO actualizarPersonaDTO);

        void Delete(int id);

    }
}
