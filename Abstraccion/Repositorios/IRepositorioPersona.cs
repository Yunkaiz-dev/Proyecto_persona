using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Proyecto_persona.DTO;
using Proyecto_persona.Models;

namespace Proyecto_persona.Abstraccion.Repositorios
{
    
    public interface IRepositorioPersona
    {
        List<Persona> Get();
        
        Persona GetById(int id);
        
        Persona Create(CrearPersonaDTO crearPersonaDTO);
  
        Persona Update(int id,ActualizarPersonaDTO actualizarPersonaDTO);

        void Delete(int id);
        

        
    }
}
