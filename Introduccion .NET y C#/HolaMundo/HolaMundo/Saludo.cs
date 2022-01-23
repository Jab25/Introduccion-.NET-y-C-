using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Saludo
    {
        public string Solicitarnombre()
        {
            string nombre;
            Console.WriteLine("Como te llamas?");
            nombre = Console.ReadLine();
            return nombre;
        }
        /* retorna el datoobtenido anteriormente*/
        public void Saludar(string nombre)
        {
            Console.WriteLine(" Hola" + nombre);
            Console.ReadKey();
        }
    }
}
