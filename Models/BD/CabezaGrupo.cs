using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class CabezaGrupo
    {
        public CabezaGrupo()
        {
            CuerpoGrupo = new HashSet<CuerpoGrupo>();
        }

        public int Idgrupo { get; set; }
        public string Tema { get; set; }
        public int? Iddocente { get; set; }
        public decimal? Nota { get; set; }
        public int? Estado { get; set; }

        public virtual Docente IddocenteNavigation { get; set; }
        public virtual ICollection<CuerpoGrupo> CuerpoGrupo { get; set; }
    }
}
