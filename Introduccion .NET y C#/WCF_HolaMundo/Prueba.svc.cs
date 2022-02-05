using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_HolaMundo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Prueba" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Prueba.svc o Prueba.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Prueba : IPrueba
    {
        public int Resta(int i, int j)
        {
            return i - j;
        }

        public int Suma(int i, int j)
        {
            return i + j;
        }

        Alumno IPrueba.Alumno(int Id, string Name)
        {
            throw new NotImplementedException();
        }
    }
}
