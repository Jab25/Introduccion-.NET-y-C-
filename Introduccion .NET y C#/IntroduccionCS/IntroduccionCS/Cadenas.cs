using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Cadenas
    {
        public string HolaMundo()
        {
            string nombre, papell, sapell, edad;
            Console.WriteLine("Proporciona tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Proporciona tu primer apellido");
            papell = Console.ReadLine();
            Console.WriteLine("Proporciona tu segundo apellido");
            sapell = Console.ReadLine();
            Console.WriteLine("Proporciona tu edad");
            edad = Console.ReadLine();

            Console.WriteLine(" Hola" + " " + nombre.Trim() + " " + papell.Trim() + " " + sapell.Trim() + " " + edad.Trim());
            Console.WriteLine(string.Format("{0} {1} {2} tiene {3} años", nombre.Trim(), papell.Trim(), sapell.Trim(), edad.Trim()));

            Console.WriteLine($"Gusto en conocerte {nombre.ToUpper()} {papell.ToUpper()} {sapell.ToUpper()}");

            string ruta = "C:\\Users\\Tichs\\Documents\\Desarrollador.NET\\Introduccion.NET y C#\\NewDocument.docx";
            Console.WriteLine("El archivo fue almacenado en " + ruta);

            //string nombreCom = (nombre + papell + sapell + edad); ;
            //string[] partesNombre = nombreCom.Split(' ');
            //Console.WriteLine(nombreCom);

            Console.ReadKey();

            return nombre;
        }
    }
}
