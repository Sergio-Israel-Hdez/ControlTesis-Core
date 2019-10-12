using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            CuerpoGrupo = new HashSet<CuerpoGrupo>();
        }

        public int Idestudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Idcarrera { get; set; }
        public int? Idusuario { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaN { get; set; }
        public DateTime? FechaR { get; set; }
        public int? Estado { get; set; }

        public virtual Carrera IdcarreraNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<CuerpoGrupo> CuerpoGrupo { get; set; }
    }
}
