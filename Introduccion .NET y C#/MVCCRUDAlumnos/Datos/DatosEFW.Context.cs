﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class CapacitacionEntities : DbContext
    {
        public CapacitacionEntities()
            : base("name=CapacitacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstatusAlumnos> EstatusAlumnos { get; set; }
    }
}
