using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstatusAlumno
    {
        private CapacitacionEntities db = new CapacitacionEntities();
        public List<EstatusAlumnos> consultar()
        {
            List<EstatusAlumnos> cons = db.EstatusAlumnos.ToList();
            return cons;
        }
    }
}

