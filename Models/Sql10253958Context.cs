using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aspnetmvc5.Models
{
    public partial class Sql10253958Context : DbContext
    {
        public Sql10253958Context()
        {
        }

        public Sql10253958Context(DbContextOptions<Sql10253958Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Facturas> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=sql10.freemysqlhosting.net;database=sql10253958;user=sql10253958;pwd=Rjd993MQTP;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.ToTable("facturas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasColumnType("int(255)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("int(255)");

            });
        }
    }
}
