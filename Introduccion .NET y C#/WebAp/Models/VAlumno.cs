using System;
using System.Collections.Generic;

#nullable disable

namespace WebAp.Models
{
    public partial class VAlumno
    {
        public int IdAlumnos { get; set; }
        public string NombreAlumno { get; set; }
        public string PrimerApellidoAlumno { get; set; }
        public string SegundoApellidoAlumno { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Curp { get; set; }
        public string Estado { get; set; }
        public string Estatus { get; set; }
    }
}
