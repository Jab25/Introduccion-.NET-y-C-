using System;
using System.Collections.Generic;

#nullable disable

namespace WebAp.Models
{
    public partial class CursosInstructore
    {
        public int IdCursosInstructores { get; set; }
        public short IdCurso { get; set; }
        public int IdInstructor { get; set; }
        public DateTime? FechaContratacion { get; set; }

        public virtual Instructore IdCurso1 { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
    }
}
