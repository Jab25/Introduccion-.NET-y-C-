using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class NAlumno
    {
        private DAlumno _dAlumno;

       public NAlumno()
        {
            _dAlumno = new DAlumno();
        }
        public void Actualizar(Alumno alumno) => _dAlumno.actualizar(alumno);

        public void Agregar(Alumno alumno) => _dAlumno.agregar(alumno);

        public List<Alumno> Consultar()  => _dAlumno.consultar();

        public Alumno Consultar(int id) => _dAlumno.consultar(id);

        public void Eliminar(int id) => _dAlumno.Eliminar(id);
    }
}
