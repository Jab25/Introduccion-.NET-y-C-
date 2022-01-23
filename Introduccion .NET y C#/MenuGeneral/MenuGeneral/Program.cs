using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean f = false;
            string eleg;
            while (!f) { 
            
                Console.WriteLine("1.- Cadenas - arreglos \n 2.- Enteros - Numero mayor \n 3.- Convierte A Tipo Oracion \n" +
                    " 4.- Presentacion - Poliza \n 5.- Leer Archivo txt \n 6.- Escribir Archivo \n " +
                    "7.- Calculo de Impuesto Sobre la Renta \n 8.- Opción 8 \n F.- Termina");
                                
                    Console.WriteLine("Seleccione una opción", ConsoleColor.Red);
                    eleg = Console.ReadLine();

                if (eleg.Equals("1")) 
                        {
                    Arreglos arreglito = new Arreglos();
                    arreglito.Cadenas();
                        }
                else if (eleg.StartsWith("2"))
                {
                    Arreglos arreglito = new Arreglos();
                    arreglito.Enteros();
                }
                else if (eleg.Equals("3"))
                {
                    Arreglos arreglito = new Arreglos();
                    arreglito.ConvierteATipoOracion();
                }
                else if (eleg.StartsWith("4"))
                {
                    Poliza poliza = new Poliza();
                    poliza.Presentacion();
                }
                else if (eleg.Equals("5"))
                {
                    Archivotxt leerArchivo = new Archivotxt();
                    leerArchivo.Presentacion();
                }
                else if (eleg.StartsWith("6"))
                {
                    Archivotxt escribir = new Archivotxt();
                    escribir.EscribirTxt();
                }
                else if (eleg.Equals("7"))
                {
                    ISR pres = new ISR();
                    pres.Presentacion();
                }
                else if (eleg.StartsWith("8"))
                    Console.WriteLine("Usted seleccionó la opción 8");
                else if (eleg.StartsWith("F"))
                    Environment.Exit(0);
                else
                    Console.WriteLine("No se encontro la eleccion", ConsoleColor.Red);
                }
                Console.ReadKey();
        }
    }
}
