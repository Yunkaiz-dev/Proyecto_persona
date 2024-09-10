using Microsoft.EntityFrameworkCore;
using Proyecto_persona.Abstraccion.Repositorios;
using Proyecto_persona.Abstraccion.Servicios;
using Proyecto_persona.DTO;
using Proyecto_persona.Implementaciones.Repositorios;
using Proyecto_persona.Models;

namespace Proyecto_persona.Implementaciones.Servicios
{
    public class ServicioPersona : IServicioPersona
    {
        private readonly IRepositorioPersona repositorio;
        
        public ServicioPersona (IRepositorioPersona Repositorio)
        {
            repositorio = Repositorio;
        }
        public PersonaDTO Create(CrearPersonaDTO crearPersonaDTO)
        {
            var persona = repositorio.Create(crearPersonaDTO);
            var personaDTO = new PersonaDTO
            {
                Id = persona.Id,
                PrimerNombre = persona.PrimerNombre,
                SegundoNombre = persona.SegundoNombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido,
                Cedula = persona.Cedula,
                AñoNacimiento = persona.AñoNacimiento,
                MesNacimiento = persona.MesNacimiento,
                DiaNacimiento = persona.DiaNacimiento,
                CodigoAreaNumero = persona.CodigoAreaNumero,
                CodigoPaisNumero = persona.CodigoPaisNumero,
                CasaNumeroDireccion = persona.CasaNumeroDireccion,
                CalleDireccion = persona.CalleDireccion,
                CiudadDireccion = persona.CiudadDireccion,
                ProvinciaDireccion = persona.ProvinciaDireccion,
                PaisDireccion = persona.PaisDireccion,
            };
            return personaDTO;

        }

        public void Delete(int id)
        {
            repositorio.Delete(id);
        }

        public List<PersonaDTO> Get()
        {
            var personas = repositorio.Get();
            var personasDTO = new List<PersonaDTO>();

            foreach (Persona persona in personas)
            {
                var result = new PersonaDTO
                {
                    Id = persona.Id,
                    PrimerNombre = persona.PrimerNombre,
                    SegundoNombre = persona.SegundoNombre,
                    PrimerApellido = persona.PrimerApellido,
                    SegundoApellido = persona.SegundoApellido,
                    Cedula = persona.Cedula,
                    AñoNacimiento = persona.AñoNacimiento,
                    MesNacimiento = persona.MesNacimiento,
                    DiaNacimiento = persona.DiaNacimiento,
                    CodigoAreaNumero = persona.CodigoAreaNumero,
                    CodigoPaisNumero = persona.CodigoPaisNumero,
                    CasaNumeroDireccion = persona.CasaNumeroDireccion,
                    CalleDireccion = persona.CalleDireccion,
                    CiudadDireccion = persona.CiudadDireccion,
                    ProvinciaDireccion = persona.ProvinciaDireccion,
                    PaisDireccion = persona.PaisDireccion
                };           
                personasDTO.Add(result); 
            }
            return personasDTO;
        }

        public Persona GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public PersonaDTO Update(int id, ActualizarPersonaDTO actualizarPersonaDTO)
        {
            var persona = repositorio.Update(id, actualizarPersonaDTO);
            var personaDTO = new PersonaDTO
            {
                Id = id,
                PrimerNombre = persona.PrimerNombre,
                SegundoNombre = persona.SegundoNombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido,
                Cedula = persona.Cedula,
                AñoNacimiento = persona.AñoNacimiento,
                MesNacimiento = persona.MesNacimiento,
                DiaNacimiento = persona.DiaNacimiento,
                CodigoAreaNumero = persona.CodigoAreaNumero,
                CodigoPaisNumero = persona.CodigoPaisNumero,
                CasaNumeroDireccion = persona.CasaNumeroDireccion,
                CalleDireccion = persona.CalleDireccion,
                CiudadDireccion = persona.CiudadDireccion,
                ProvinciaDireccion = persona.ProvinciaDireccion,
                PaisDireccion = persona.PaisDireccion
            };
            return personaDTO;
        }
    }
}
