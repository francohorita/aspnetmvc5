using System;
using System.Collections.Generic;

namespace aspnetmvc5.Models
{
    public partial class Facturas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public int Usuario { get; set; }
        public DateTime Creado { get; set; }
    }
}
