﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class SistemaDiscograficoDb : DbContext
    {
        public SistemaDiscograficoDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuario { get; set; }
        public virtual DbSet<Discos> disco { get; set; }
        
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetallesDeDiscos> DetalleDeDiscos { get; set; }
        public virtual DbSet<Factura> DetallesFacturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                  .HasMany<Discos>(df => df.Discos)
                  .WithMany(p => p.Factura)
                  .Map(dfp =>
                  {
                      dfp.MapLeftKey("DiscoId");
                      dfp.MapRightKey("FacturaId");
                      dfp.ToTable("FacturaProductos");
                  });
        }

    }
}
