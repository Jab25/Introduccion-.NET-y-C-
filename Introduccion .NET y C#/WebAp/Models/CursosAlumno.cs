using System;
using System.Collections.Generic;

#nullable disable

namespace WebAp.Models
{
    public partial class CursosAlumno
    {
        public int IdCursosAlumnos { get; set; }
        public short IdCurso { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public byte? Calificacion { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
    }
}
