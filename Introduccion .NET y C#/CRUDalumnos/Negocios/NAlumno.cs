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

        public TablaISR CalcularISR(int id)
        {
            List<TablaISR> listTablaISR = _dAlumno.ConsultarTablaISR();
            Alumno alum = Consultar(id);
            var quincenal = alum.sueldo/2;
            var calculoISR = from isr in listTablaISR
                             where quincenal >= isr.límiteinferior && quincenal <= isr.límitesuperior
                             select new TablaISR
                             {
                                 límiteinferior = isr.límiteinferior,
                                 límitesuperior = isr.límitesuperior,
                                 cuotaFija = isr.cuotaFija,
                                 excedente = isr.excedente,
                                 subsidio = isr.subsidio,
                                 impuesto = (((quincenal - isr.límiteinferior)*(isr.excedente/100)+isr.cuotaFija)-isr.subsidio)
                                 
                                 //((((quincenal) - isr.límiteinferior) 
                                 //* (isr.excedente / 100)) + isr.cuotaFija) - isr.subsidio
                             };
            var nec = calculoISR.FirstOrDefault();
            return nec;
        }
        public AportacionesIMSS CalcularIMSS(int id)
        {
            Alumno datos = Consultar(id);
            decimal sueldo = datos.sueldo;

            AportacionesIMSS IMSSdatos = new AportacionesIMSS();
            {
                IMSSdatos.enfermedadMaternidad = (sueldo - (3 * 2925.09m)) * 0.004m;
                IMSSdatos.invalidezVida = sueldo * 0.00625m;
                IMSSdatos.retiro = sueldo * 0m;
                IMSSdatos.cesantía = sueldo * 0.01125m;
                IMSSdatos.infonavit = sueldo * 0m;
            }
            return IMSSdatos;
        }
    }
}
