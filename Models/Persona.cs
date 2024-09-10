using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_persona.Models;

public partial class Persona
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string? Cedula { get; set; }

    public int AñoNacimiento { get; set; }

    public int MesNacimiento { get; set; }

    public int DiaNacimiento { get; set; }

    public string? CodigoAreaNumero { get; set; }

    public string? CodigoPaisNumero { get; set; }

    public int? CasaNumeroDireccion { get; set; }

    public string? CalleDireccion { get; set; }

    public string? CiudadDireccion { get; set; }

    public string? ProvinciaDireccion { get; set; }

    public string? PaisDireccion { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
