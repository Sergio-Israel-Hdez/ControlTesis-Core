using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class CuerpoGrupo
    {
        public int Iddetalle { get; set; }
        public int? Idestudiante { get; set; }
        public int? Idgrupo { get; set; }

        public virtual Estudiante IdestudianteNavigation { get; set; }
        public virtual CabezaGrupo IdgrupoNavigation { get; set; }
    }
}
