﻿using System;
using System.Collections.Generic;

namespace aspnetmvc5.Models
{
    public partial class MateriasProfesores
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Creado { get; set; }
    }
}
