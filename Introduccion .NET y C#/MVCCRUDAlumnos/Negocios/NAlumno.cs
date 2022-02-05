using Datos;
using Entidades;
using Negocios.WCFservicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NAlumno
        {
        private Negocios.WCFservicios.AlumnoWCFClient serv = new Negocios.WCFservicios.AlumnoWCFClient();
        private DAlumno dalumno = new DAlumno();

        private DAlumno _dAlumno;


            public NAlumno()
            {
                _dAlumno = new DAlumno();
            }
            public void Actualizar(Alumnos alumno) => _dAlumno.Actualizar(alumno);

            public void Agregar(Alumnos alumno) => _dAlumno.Agregar(alumno);

            public List<Alumnos> Consultar() => _dAlumno.Consultar();

            public Alumnos Consultar(int id) => _dAlumno.Consultar(id);

            public void Eliminar(int id) => _dAlumno.Eliminar(id);
            public AportacionesIMSS CalcularIMMS(int id)
            {

                return serv.CalcularIMSS(id)
    ;
            }
            public TablaISR CalcularISR(int id)
            {
                return serv.CalcularISR(id)
    ;
            }

    }
}
