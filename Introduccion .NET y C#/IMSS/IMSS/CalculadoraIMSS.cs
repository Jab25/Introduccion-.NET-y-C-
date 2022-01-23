using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        /*c) Crear la estructura llamada Aportaciones con 5 valores decimales
         *llamados EnfermedadMaternidad, InvalidezVida, Retiro, Cesantia, Infonavit.*/

        struct Aportaciones
        {
            public decimal EnfermedadMaternidad, InvalidezVida, Retiro, Cesantia, Infonavit;

            public Aportaciones(decimal EM, decimal IV, decimal Ret, decimal Cesa, decimal Info)
            
            {
                this.EnfermedadMaternidad = EM;
                this.InvalidezVida = IV;
                this.Retiro = Ret;
                this.Cesantia = Cesa;
                this.Infonavit = Info;
            }
        }
        /*d) Crear un método estático Calcular el cual calcule las siguientes
        aportaciones, recibiendo el Salario Base de Cotización (SBC), la Unidad de
        Medida de Actualización (UMA), y un indicador de si es Patrón o
        Trabajador. El método deberá hacer los siguientes cálculos, con base en los
        parámetros recibidos y regresar los resultados en la Estructura
        Aportaciones*/
        public void Calcular(decimal SBC, decimal UMA, int tipo)
        {
            
            if(tipo == 1)

            {
                decimal EM = (SBC - (3 * UMA))*0.4m;
                decimal IV = SBC * 0.625m;
                decimal Ret =(SBC) * 0m;
                decimal Cesa = SBC * 1.125m;
                decimal Info = (SBC) * 0m;
                Console.WriteLine("El resultado para Trabajador es: " + "\n" +
                    "EnfermedadMaternidad: " + EM + "\n" +
                    "InvalidezVida: " + IV + "\n" +
                    "Retiro: " + Ret + "\n" +
                    "Cesantia: " + Cesa + "\n" +
                    "Infonavit: " + Info);

            }
            else
            {
                decimal EM = (SBC - (3 * UMA) * 1.1m);
                decimal IV = (SBC) * 1.75m;
                decimal Ret = (SBC) * 2;
                decimal Cesa = (SBC) * 3.150m;
                decimal Info = (SBC) * 5m;
                Console.WriteLine("El resultado para Patron es: " + "\n" +
                    "EnfermedadMaternidad: " + EM + "\n" +
                    "InvalidezVida: " + IV + "\n" +
                    "Retiro: " + Ret + "\n" +
                    "Cesantia: " + Cesa + "\n" +
                    "Infonavit: " + Info);

            }
        }
        /*e) Crear el Método estático Presentacion, el cual solicitara al usuario los el
        Sueldo Basico de Cotizacion, La Unidad de Medida de Actualizacion, y el
        indicador se el cálculo se requiere para el Patron o para el trabajador, con
        ello llamar al método Calcular, y mostrar los resultados, asi como el total*/
        public void Presentacion()
        {
            decimal SBC, UMA;
            int tipo;
            Console.WriteLine("Salario Base de Cotización(SBC)");
            SBC = decimal.Parse(Console.ReadLine());
            Console.WriteLine("La Unidad de Medida de Actualización(UMA)");
            UMA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Indique 2 = Patrón o 1 = Trabajador");
            tipo = int.Parse(Console.ReadLine());
            
                Calcular(SBC, UMA, tipo);
                Console.ReadLine();
        }
    }
}
