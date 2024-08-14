using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Proyecto_persona.DTO;
using Proyecto_persona.Models;

namespace Proyecto_persona.Abstraccion.Repositorios
{
    
    public interface IRepositorioPersona
    {
        List<PersonaDTO> Get();
        
        PersonaDTO GetById(int id);
        
        PersonaDTO Create(CrearPersonaDTO crearPersonaDTO);
  
        PersonaDTO Update(ActualizarPersonaDTO actualizarPersonaDTO);

        void Delete(int id);
        

        
    }
}
