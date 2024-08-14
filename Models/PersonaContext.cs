using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_persona.Models;

public partial class PersonaContext : DbContext
{
    public PersonaContext()
    {
    }

    public PersonaContext(DbContextOptions<PersonaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI;Database=Persona;User Id=sa;Password=0928; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personas__3213E83FB1F52CE6");

            entity.ToTable("personas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AñoNacimiento).HasColumnName("año_nacimiento");
            entity.Property(e => e.CalleDireccion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("calle_direccion");
            entity.Property(e => e.CasaNumeroDireccion).HasColumnName("casa_numero_direccion");
            entity.Property(e => e.Cedula).HasColumnName("cedula");
            entity.Property(e => e.CiudadDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciudad_direccion");
            entity.Property(e => e.CodigoAreaNumero).HasColumnName("codigo_area_numero");
            entity.Property(e => e.CodigoPaisNumero).HasColumnName("codigo_pais_numero");
            entity.Property(e => e.DiaNacimiento).HasColumnName("dia_nacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.MesNacimiento).HasColumnName("mes_nacimiento");
            entity.Property(e => e.PaisDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pais_direccion");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("primer_nombre");
            entity.Property(e => e.ProvinciaDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("provincia_direccion");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("segundo_nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
