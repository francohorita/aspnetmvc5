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
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
            }
        }

        public FacturasContext(DbContextOptions opt) : base(opt) { }

        public DbSet<Factura> facturas { get; set; }

    }
}
