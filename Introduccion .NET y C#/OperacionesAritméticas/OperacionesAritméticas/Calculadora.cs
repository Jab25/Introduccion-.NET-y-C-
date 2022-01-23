using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    internal class Calculadora
    {
        static void suma(decimal num1, decimal num2)
        {
            decimal Resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + Resultado);
        }
        static void resta(decimal num1, decimal num2)
        {
            decimal Resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + Resultado);
        }
        static void multiplicar(decimal num1, decimal num2)
        {
            decimal Resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicaion es: " + Resultado);
        }
        static void division(decimal num1, decimal num2)
        {
            decimal Resultado = (num1 / num2);
            Console.WriteLine("El resultado de la division es: " + Resultado);

        }
        static void modulo(decimal num1, decimal num2)
        {
            decimal Resultado = (num1 % num2);
            Console.WriteLine(" El resultado del modulo es: " + Resultado);
        }

        public enum tipoOperacion : int
        {
            suma = 1,
            resta = 2,
            multiplicar = 3,
            division = 4,
            modulo = 5,
        }

        struct operacion
        {
            public decimal operando1, operando2;
            public tipoOperacion operador;

            public operacion(decimal operan1, decimal operan2, tipoOperacion opera)
            {
                this.operando1 = operan1;
                this.operando2 = operan2;
                this.operador = opera;
            }

        }
        public void Operacion(tipoOperacion opera, decimal operando1, decimal operando2)

        {
            switch (opera)
            {
                case tipoOperacion.suma:
                    suma(operando1, operando2);
                    break;
                case tipoOperacion.resta:
                    resta(operando1, operando2);
                    break;
                case tipoOperacion.multiplicar:
                    multiplicar(operando1, operando2);
                    break;
                case tipoOperacion.division:
                    division(operando1, operando2);
                    break;
                case tipoOperacion.modulo:
                    modulo(operando1, operando2);
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }

        }
        struct Resultado
        {
            public int suma, resta, multiplicar, division, modulo;
            public Resultado(int sum, int res, int multi, int div, int modu)
            {
                suma = sum;
                resta = res;
                multiplicar = multi;
                division = div;
                modulo = modu;
            }

        }

        static void Simultaneas(decimal num1, decimal num2)
        {
            Resultado resul = new Resultado();
            resul.suma = 1;
            resul.resta = 2;
            resul.multiplicar = 3;
            resul.division = 4;
            resul.modulo = 5;
            Calculadora calcu = new Calculadora();

            int[] TodasOperaciones = new int[] { resul.suma, resul.resta, resul.multiplicar, resul.division, resul.modulo };
            for (int i = 0; i < TodasOperaciones.Length; i++)
            {
                calcu.Operacion((tipoOperacion)TodasOperaciones[i], num1, num2);
            }

        }

        public void Presentacion()
        {
            Console.WriteLine("OPERACION A REALIZAR\n1.- Suma\n2.- Resta\n3.- Multiplicación\n4.- Dividir\n5.- Módulo\n6- Todas");
            Console.WriteLine("Selecciona Operación a realizar");
            int Opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el primer operador");
            int Operador1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el segundo operador");
            int Operador2 = int.Parse(Console.ReadLine());
            if (Opcion == 6)
            {
                Console.WriteLine("Todas las operaciones");
                Simultaneas(Operador1, Operador2);
                Console.ReadLine();
            }
            else
            {
                Operacion((tipoOperacion)Opcion, Operador1, Operador2);
                Console.ReadLine();
            }

        }
    }
}
