using System;
using System.Collections.Generic;

namespace aspnetmvc5.Models
{
    public partial class CarrerasMaterias
    {
        public int Id { get; set; }
        public int CarreraId { get; set; }
        public int MateriaId { get; set; }
        public DateTime Creado { get; set; }
    }
}
