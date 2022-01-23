using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuGeneral
{
    internal class ISR
    {
            decimal[,] tabla = new decimal[21, 5];
            decimal[,] CargarTabla(string file)
            {
                Console.WriteLine("\n");
                StreamReader sr = new StreamReader(
                @"C:\\Users\\Tichs\\Documents\\Capacitacion JOM\\SQL\\" + file + ".csv");
                string csv = sr.ReadToEnd();
                string[] campos = new string[105];
                campos = csv.Split(',');
                int i = 0;
                for (int j = 0; j < 21; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        tabla[j, k] = decimal.Parse(campos[i++]);
                    }
                }
                return tabla;
            }
        static void Calcular(decimal SueldoMensual, decimal[,] tabla)
        {
            decimal SueldoQuincenal = SueldoMensual / 2;
            decimal excedente, porcentaje, calculo, total;

            for (int i = 0; i < 21; i++)
            {
                if (tabla[i, 0] <= SueldoQuincenal && tabla[i,1] >= SueldoQuincenal)
                {
                    excedente = SueldoQuincenal - tabla[i,1];
                    porcentaje = excedente * (tabla[i, 3]/100);
                    calculo = porcentaje + tabla[i,2];
                    total = calculo + tabla[i,4];

                    Console.WriteLine("El total ISR a pagar; " + total);
                    break;
                }
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("Nombre del archivo que contiene la tabla del ISR ");
            string file = Console.ReadLine();
            CargarTabla(file);
            Console.WriteLine("Sueldo mensual ");
            decimal SueldoMensual = decimal.Parse(Console.ReadLine());
            Calcular(SueldoMensual, tabla);
            
        }
    }
}
