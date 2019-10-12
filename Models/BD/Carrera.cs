using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Carrera
    {
        public Carrera()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        public int Idcarrera { get; set; }
        public string Nombre { get; set; }
        public string Plans { get; set; }
        public int? Estado { get; set; }
        public int? Idfacultad { get; set; }

        public virtual Facultad IdfacultadNavigation { get; set; }
        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}
