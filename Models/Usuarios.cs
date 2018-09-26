using System;
using System.Collections.Generic;

namespace aspnetmvc5.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Legajo { get; set; }
        public string Mail { get; set; }
        public DateTime Fechanac { get; set; }
        public DateTime Ingreso { get; set; }
        public float Sueldo { get; set; }
        public DateTime Creado { get; set; }

        public int CalcularEdad()
        {
            return 20;
        }
    }
}
