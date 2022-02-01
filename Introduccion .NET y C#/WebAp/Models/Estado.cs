﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebAp.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public int IdEstados { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
