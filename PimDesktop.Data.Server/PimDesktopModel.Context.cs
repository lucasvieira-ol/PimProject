﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PimDesktop.Data.Server
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_pim_hmlEntities : DbContext
    {
        public db_pim_hmlEntities()
            : base("name=db_pim_hmlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<funcionario> funcionario { get; set; }
        public virtual DbSet<hospede> hospede { get; set; }
        public virtual DbSet<perfil> perfil { get; set; }
        public virtual DbSet<quarto> quarto { get; set; }
        public virtual DbSet<registro_pagamento> registro_pagamento { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<usuario_cartao> usuario_cartao { get; set; }
        public virtual DbSet<usuario_hospede> usuario_hospede { get; set; }
        public virtual DbSet<usuario_sistema> usuario_sistema { get; set; }
        public virtual DbSet<acompanhante> acompanhante { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}