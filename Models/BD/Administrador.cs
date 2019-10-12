using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Administrador
    {
        public int Idadmin { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int? Estado { get; set; }
        public int? Idusuario { get; set; }

        public virtual Usuario IdusuarioNavigation { get; set; }
    }
}
