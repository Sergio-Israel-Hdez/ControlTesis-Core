using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class CabezaGrupoEstudiante
    {
        public int IdGrupo { get; set; }
        public string Docente { get; set; }
        public string Tema {get;set;}
        public decimal? Nota { get; set; }
    }
}
