using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iFiguras[] figuras = { new Cuadrado { Lado = 5 }, new Triangulo { Lado = 5 } };
            foreach (var resul in figuras)
            {
                Console.WriteLine($"{resul.ToString()}, " +
                                  $","+
                                  $"Area: {resul.Area()}," +
                                  $"Perimetro: {resul.Perimetro()}");
                Console.ReadKey();  
            }
        }        
    }
}
