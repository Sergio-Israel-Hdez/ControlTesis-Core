﻿using System;
using System.Collections.Generic;

namespace ControlTesisCore.Models.BD
{
    public partial class Usuario
    {
        public Usuario()
        {
            Administrador = new HashSet<Administrador>();
            Docente = new HashSet<Docente>();
            Estudiante = new HashSet<Estudiante>();
        }

        public int Idusuario { get; set; }
        public string Carnet { get; set; }
        public string Contraseña { get; set; }
        public int? Estado { get; set; }
        public int? Rol { get; set; }

        public virtual ICollection<Administrador> Administrador { get; set; }
        public virtual ICollection<Docente> Docente { get; set; }
        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}
