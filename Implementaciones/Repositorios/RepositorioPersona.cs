using Proyecto_persona.Abstraccion.Repositorios;
using Proyecto_persona.DTO;
using Proyecto_persona.Models;

namespace Proyecto_persona.Implementaciones.Repositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly PersonaContext _context;
        public RepositorioPersona(PersonaContext context)
        {
            _context = context;
        }

        public Persona Create(CrearPersonaDTO crearPersonaDTO)
        {
            var resultado = new Persona
            {
                PrimerNombre = crearPersonaDTO.PrimerNombre,
                SegundoNombre = crearPersonaDTO.SegundoNombre,
                PrimerApellido = crearPersonaDTO.PrimerApellido,
                SegundoApellido = crearPersonaDTO.SegundoApellido,
                Cedula = crearPersonaDTO.Cedula,
                AñoNacimiento = crearPersonaDTO.AñoNacimiento,
                MesNacimiento = crearPersonaDTO.MesNacimiento,
                DiaNacimiento = crearPersonaDTO.DiaNacimiento,
                CodigoAreaNumero = crearPersonaDTO.CodigoAreaNumero,
                CodigoPaisNumero = crearPersonaDTO.CodigoPaisNumero,
                CasaNumeroDireccion = crearPersonaDTO.CasaNumeroDireccion,
                CalleDireccion = crearPersonaDTO.CalleDireccion,
                CiudadDireccion = crearPersonaDTO.CiudadDireccion,
                ProvinciaDireccion = crearPersonaDTO.ProvinciaDireccion,
                PaisDireccion = crearPersonaDTO.PaisDireccion
            };  
            _context.Personas.Add(resultado);
            _context.SaveChanges(); 
            return resultado;
        }

        public void Delete(int id)
        {
            Persona persona = GetById(id);
            _context.Remove(persona); 
            _context.SaveChanges();
        }

        public List<Persona> Get()
        {
            return [.. _context.Personas];
        } 

        public Persona GetById(int id)
        {
            return _context.Personas.Where(p => p.Id == id).FirstOrDefault();
        }

        public Persona Update(int id,ActualizarPersonaDTO actualizarPersonaDTO)
        {
            
            var persona_existente = GetById(id);

            persona_existente.PrimerNombre = actualizarPersonaDTO.PrimerNombre ?? persona_existente.PrimerNombre;
            persona_existente.SegundoNombre = actualizarPersonaDTO.SegundoNombre ?? persona_existente.SegundoNombre;
            persona_existente.PrimerApellido = actualizarPersonaDTO.PrimerApellido ?? persona_existente.PrimerApellido;
            persona_existente.SegundoApellido = actualizarPersonaDTO.SegundoApellido ?? persona_existente.SegundoApellido;
            persona_existente.Cedula = actualizarPersonaDTO.Cedula ?? persona_existente.Cedula; 
            persona_existente.AñoNacimiento = actualizarPersonaDTO.AñoNacimiento ?? persona_existente.AñoNacimiento;
            persona_existente.MesNacimiento = actualizarPersonaDTO.MesNacimiento ?? persona_existente.MesNacimiento;
            persona_existente.DiaNacimiento = actualizarPersonaDTO.DiaNacimiento ?? persona_existente.DiaNacimiento;
            persona_existente.CodigoAreaNumero = actualizarPersonaDTO.CodigoAreaNumero ?? persona_existente.CodigoAreaNumero;
            persona_existente.CodigoPaisNumero = actualizarPersonaDTO.CodigoPaisNumero ?? persona_existente.CodigoPaisNumero;
            persona_existente.CasaNumeroDireccion = actualizarPersonaDTO.CasaNumeroDireccion ?? persona_existente.CasaNumeroDireccion;
            persona_existente.CalleDireccion = actualizarPersonaDTO.CalleDireccion ?? persona_existente.CalleDireccion;
            persona_existente.CiudadDireccion = actualizarPersonaDTO.CiudadDireccion ?? persona_existente.CiudadDireccion;
            persona_existente.ProvinciaDireccion = actualizarPersonaDTO.ProvinciaDireccion ?? persona_existente.ProvinciaDireccion;
            persona_existente.PaisDireccion = actualizarPersonaDTO.PaisDireccion ?? persona_existente.PaisDireccion;

            _context.Update(persona_existente);
            _context.SaveChanges();

            var persona_actualizada = GetById(id);
            return persona_actualizada;


        }
    }
}
