using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace aspnetmvc5.Controllers
{
    public class FacturasContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public DbSet<Factura> Facturas { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
            optionsBuilder.UseMySQL("server=sql10.freemysqlhosting.net;database=sql10253958;user=sql10253958;password=Rjd993MQTP");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.fecha);
                entity.Property(e => e.cliente);
            });

        }

        /*public FacturasContext(DbContextOptions opt) : base(opt) { }*/

    }
}
