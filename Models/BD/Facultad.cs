using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Facultad
    {
        public Facultad()
        {
            Carrera = new HashSet<Carrera>();
        }

        public int Idfacultad { get; set; }
        public string Nombre { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<Carrera> Carrera { get; set; }
    }
}
