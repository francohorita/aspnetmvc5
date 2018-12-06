using System;
using System.Collections.Generic;

namespace aspnetmvc5.Models
{
    public partial class MateriasConUsuario
    {
        public List<Materias> Materias { get; set; }
        public string UserId { get; set; }
    }
}
