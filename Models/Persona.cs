﻿using System;
using System.Collections.Generic;

namespace Proyecto_persona.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public int Cedula { get; set; }

    public int AñoNacimiento { get; set; }

    public int MesNacimiento { get; set; }

    public int DiaNacimiento { get; set; }

    public int CodigoAreaNumero { get; set; }

    public int CodigoPaisNumero { get; set; }

    public int? CasaNumeroDireccion { get; set; }

    public string? CalleDireccion { get; set; }

    public string? CiudadDireccion { get; set; }

    public string? ProvinciaDireccion { get; set; }

    public string? PaisDireccion { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
