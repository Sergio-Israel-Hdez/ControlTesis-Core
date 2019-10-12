using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Docente
    {
        public Docente()
        {
            CabezaGrupo = new HashSet<CabezaGrupo>();
        }

        public int Iddocente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NSeguro { get; set; }
        public string Correo { get; set; }
        public int? Estado { get; set; }
        public int? Idusuario { get; set; }

        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<CabezaGrupo> CabezaGrupo { get; set; }
    }
}
