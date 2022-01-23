using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo solicito = new Saludo();
            string nombre;
            nombre = solicito.Solicitarnombre();
            solicito.Saludar(nombre);
            /**/
        }
    }
}
