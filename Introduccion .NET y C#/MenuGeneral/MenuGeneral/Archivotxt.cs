using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        public void MostrarTxt(string tipoArcTxt)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tichs\Documents\Capacitacion JOM\introduccion .NET\" + tipoArcTxt + ".txt");
            Console.WriteLine("Contenido del archivo: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
        static void MostrarCSV(string tipoArcCsv)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tichs\Documents\Capacitacion JOM\SQL\" + tipoArcCsv + ".csv");
            Console.WriteLine("Contenido del archivo: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
        public void Presentacion()
        {
            string tipoArcTxt, tipoArcCsv;
            Console.WriteLine("Ingrese el nombre del archivo txt que desee leer:");
            tipoArcTxt = Console.ReadLine();
            MostrarTxt(tipoArcTxt);
            Console.WriteLine("\nIngrese el nombre delo archivo csv que desee leer:");
            tipoArcCsv = Console.ReadLine();
            MostrarCSV(tipoArcCsv);
            Console.ReadKey();
            Console.Clear();
        }

        public async void EscribirTxt()
            {
            Console.WriteLine("Nombre (incluyendo la ruta) del archivo a escribir: ");
            String NombreArchivo = Console.ReadLine();
            Console.WriteLine("Tipo de archivo: (1 = UTF7, 2 = UTF8, 3 = Unicod, 4 = UTF32, 5 =ASCII)");
            int tipoA = int.Parse(Console.ReadLine());
            Encoding codigoEsc = Encoding.UTF8;

            switch (tipoA)
            {
                case 1:
                        Console.WriteLine("UTF7");
                    codigoEsc = Encoding.UTF7;
                    break;
                case 2:
                    Console.WriteLine("UTF8");
                    codigoEsc= Encoding.UTF8;
                    break;
                case 3:
                    Console.WriteLine("Unicode");
                    codigoEsc=Encoding.Unicode;
                    break;
                case 4:
                    Console.WriteLine("UTF32");
                    codigoEsc = Encoding.UTF32;
                    break;
                case 5:
                    Console.WriteLine("ASCII");
                    codigoEsc = Encoding.ASCII;
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }

            String path = @"C:\\Users\\Tichs\Documents\\Capacitacion JOM\\CreacionDocumentos\\" + NombreArchivo + ".txt";
            
            if (File.Exists(path))
            {
                bool Salir = false;
                while (!Salir)
                {
                    Console.WriteLine("El archvio: " + " " + NombreArchivo + " " + "ya existe, se modificara.");
                    Console.WriteLine("Ingresa nombre: ");
                    string nombre = Console.ReadLine();
                    File.AppendAllText(path, nombre + ", ", codigoEsc);
                    Console.WriteLine("Ingresa primer apellido: ");
                    string ap = Console.ReadLine();
                    File.AppendAllText(path, ap + ", ", codigoEsc);
                    Console.WriteLine("Ingresa segundo apellido: ");
                    string am = Console.ReadLine();
                    File.AppendAllText(path, am + ", ", codigoEsc);
                    Console.WriteLine("Ingresa edad: ");
                    string edad = Console.ReadLine();
                    File.AppendAllText(path, edad + ", ", codigoEsc);
                    Console.WriteLine("Ingresa estado: ");
                    string estado = Console.ReadLine();
                    File.AppendAllText(path, estado + ", ", codigoEsc);

                    Console.WriteLine("Desea agregar un nuevo alumno? ");
                    String si = Console.ReadLine();
                    if(si == "n")
                        Salir = true;
                }
            } else
            {
                bool Salir = false;
                while (!Salir)
                {

                    Console.WriteLine(NombreArchivo + " " + ":Nombre del nuevo archivo a crear");
                Console.WriteLine("Ingresa nombre: ");
                string nombre = Console.ReadLine();
                File.AppendAllText(path, nombre + ", ", codigoEsc);
                Console.WriteLine("Ingresa primer apellido: ");
                string ap = Console.ReadLine();
                File.AppendAllText(path, ap + ", ", codigoEsc);
                Console.WriteLine("Ingresa segundo apellido: ");
                string am = Console.ReadLine();
                File.AppendAllText(path, am + ", ", codigoEsc);
                Console.WriteLine("Ingresa edad: ");
                string edad = Console.ReadLine();
                File.AppendAllText(path, edad + ", ", codigoEsc);
                Console.WriteLine("Ingresa estado: ");
                string estado = Console.ReadLine();
                File.AppendAllText(path, estado + ", ", codigoEsc);

                    Console.WriteLine("Desea agregar un nuevo alumno? ");
                    String si = Console.ReadLine();
                    if (si == "n")
                        Salir = true;
                }
            }
         }
    }
}
    