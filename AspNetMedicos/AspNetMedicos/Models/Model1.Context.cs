﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMedicos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AspNetMedicosEntities : DbContext
    {
        public AspNetMedicosEntities()
            : base("name=AspNetMedicosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<MedicosEspecialidade> MedicosEspecialidades { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}