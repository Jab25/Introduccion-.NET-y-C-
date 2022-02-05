using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_HolaMundo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPrueba" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPrueba
    {
        [OperationContract]
        int Suma(int i, int j);

        [OperationContract]
        int Resta(int i, int j);

        [OperationContract]
        Alumno Alumno(int Id, string Name);
    }
}
