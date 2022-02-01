using System;
using System.Collections.Generic;

#nullable disable

namespace WebAp.Models
{
    public partial class AlumnosTodo
    {
        public int IdAlumnos { get; set; }
        public string NombreAlumno { get; set; }
        public string PrimerApellidoAlumno { get; set; }
        public string SegundoApellidoAlumno { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public decimal? Sueldo { get; set; }
        public int IdEstadoOrigen { get; set; }
        public short IdEstatus { get; set; }
    }
}
