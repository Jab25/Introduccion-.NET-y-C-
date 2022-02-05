using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DAlumno
    {
        private CapacitacionEntities db = new CapacitacionEntities();
        public List<Alumnos> Consultar()
        {
            List<Alumnos> al = db.Alumnos.ToList();
            return al;
        }

        public Alumnos Consultar(int id)
        {
            Alumnos Alum = db.Alumnos.Find(id);
            return Alum;
        }
        public void Agregar(Alumnos alumno)
        {
            db.Alumnos.Add(alumno);
            db.SaveChanges();
        }
        public void Actualizar(Alumnos alumno)
        {
            db.Entry(alumno).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Alumnos del = db.Alumnos.Find(id);
            db.Alumnos.Remove(del);
            db.SaveChanges();
        }
    }
}
