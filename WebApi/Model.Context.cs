﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class inventariosEntities : DbContext
    {
        public inventariosEntities()
            : base("name=inventariosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<app_articulo> app_articulo { get; set; }
        public DbSet<app_conteo> app_conteo { get; set; }
        public DbSet<app_inventario> app_inventario { get; set; }
        public DbSet<app_usuario> app_usuario { get; set; }
    }
}
