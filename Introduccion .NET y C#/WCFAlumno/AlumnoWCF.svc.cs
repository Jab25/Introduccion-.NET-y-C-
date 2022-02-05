using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocios;
using Entidades;
using Newtonsoft.Json;

namespace WCFAlumno
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoWCF.svc o AlumnoWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoWCF : IAlumnoWCF
    {
        public AportacionesIMSS CalcularIMSS(int id)
        {
            NAlumno calImss = new NAlumno();
            Entidades.AportacionesIMSS imssEntidades = calImss.CalcularIMSS(id);
            AportacionesIMSS imssVacio = new AportacionesIMSS();
            imssVacio.enfermedadMaternidad = imssEntidades.enfermedadMaternidad;
            imssVacio.invalidezVida = imssEntidades.invalidezVida;
            imssVacio.retiro = imssEntidades.retiro;
            imssVacio.cesantía = imssEntidades.cesantía;
            imssVacio.infonavit = imssEntidades.infonavit;
            return imssVacio;
        }

        public TablaISR CalcularISR(int id)
        {
            NAlumno calisr = new NAlumno();
            Entidades.TablaISR isrEntidades = calisr.CalcularISR(id);
            var jsonisr = JsonConvert.SerializeObject(isrEntidades);
            System.IO.File.WriteAllText(@"C:\Users\Tichs\Documents\Desarrollador .NET\Introduccion .NET y C#\WCFAlumno\json\jsonisr.json", jsonisr);
            var desjson = JsonConvert.DeserializeObject<TablaISR>(jsonisr);
            return desjson;
        }
    }
}
