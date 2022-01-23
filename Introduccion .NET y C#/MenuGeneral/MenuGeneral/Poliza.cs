using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
        static void Calcular(DateTime FIV, int TPD, int DP, decimal SA, DateTime FN, decimal GA)
        {
            decimal[,] datos =
            {
                {0, 20, 1, 0.05m},
                {21, 30, 1, 0.1m},
                {31, 40, 1, 0.4m},
                {41, 50, 1, 0.5m},
                {51, 60, 1, 065m},
                {61, 200, 1, 085m},
                {0, 20, 2, 0.05m},
                {21, 30, 2, 0.1m},
                {31, 40, 2, 0.4m},
                {41, 50, 2, 0.55m},
                {51, 60, 2, 0.7m},
                {61M, 999, 2M, 0.9M}
            };
                
            decimal edad = CalcularEdad(FN);
            decimal factor = 0;
            for (int i = 0; i <= 11; i++)
            {
                if (datos[i, 2] == GA && edad >= datos[i, 0] && edad <= datos[i, 1])
                {
                    factor = datos[i, 3];
                    break;
                }
            }
        PolizaResultado pol = new PolizaResultado();
        string finVigencia;
            if (TPD == 1)
            {
                pol.Prima = (SA * factor) * ((DP * 365) / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = FIV.AddDays(DP* 365).ToString("dd/MM/yyyy");
        Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
            if(TPD == 2)
            {
                pol.Prima = (SA * factor) * ((DP * 30) / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = FIV.AddDays(DP* 30).ToString("dd/MM/yyyy"); ;
                Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
            if (TPD == 3)
            {
                pol.Prima = (SA * factor) * (DP / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = FIV.AddDays(DP).ToString("dd/MM/yyyy"); ;
                Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
                    }
        public static decimal CalcularEdad(DateTime fechaNac)
            {
                DateTime fechaActual = DateTime.Today;
                if (fechaNac > fechaActual)
                {
                    return -1;
                }
                else
                {
                    decimal edad = fechaActual.Year - fechaNac.Year;
                    if (fechaNac.Month > fechaActual.Month)
                    {
                        --edad;
                    }
                    return edad;
                }
            }
            public void Presentacion()
        {
            Console.WriteLine("a. Fecha de inicio de Vigencia: ");
            DateTime FIV = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("b. El tipo de periodo por el que se desea la póliza(años, meses, días): ");
            int TPD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c.La cantidad de periodos que se desean que tenga duración la póliza: ");
            int DP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d.SumaAsegurada: ");
            decimal SA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("e.Fecha de Nacimiento: ");
            DateTime FN = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("f.Género del asegurado: ");
            decimal GA = decimal.Parse(Console.ReadLine());
            Calcular(FIV, TPD, DP, SA, FN, GA);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
