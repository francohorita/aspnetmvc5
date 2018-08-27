using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc5.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetmvc5.Controllers
{

    public class Factura
    {
        public int id { get; set; }

        public DateTime fecha { get; set; }

        public int cliente { get; set; }

    }

    public class FacturasContext : DbContext
    {
        public FacturasContext(DbContextOptions opt) : base(opt) { }

        public DbSet<Factura> facturas { get; set; }

    }
}
