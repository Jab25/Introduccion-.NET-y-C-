using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos
    {
        public void Cadenas()
        {
            string nomComp;
            Console.WriteLine("Proporciona tu nombre completo");
            nomComp = Console.ReadLine();

            Console.WriteLine($"Hola");

            string[] subs = nomComp.Split();

            foreach (string sub in subs)
            {
                Console.WriteLine($"{sub}");
            }
            Console.WriteLine("Apellido vertical");
            char[] letras = subs[1].ToCharArray();
            for (int i = 0; i < subs[1].Length; i++)
            {
                Console.WriteLine(letras[i]);
            }

        }
        public void Enteros()
        {
            int num, mayor = 0;
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("Ingresa numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
        }
        public void ConvierteATipoOracion()
        {
            /*Console.WriteLine("Ingresa un texto: ");
            string text = Console.ReadLine();
            System.Text.StringBuilder sb = new System.Text.StringBuilder(text);

            for (int j = 0; j < sb.Length; j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            //Invierte las lestras si son mayusculas las pone minusculas
            Console.WriteLine($"{sb}");*/

            string oracion, mayus;
            Console.WriteLine("Ingresa una oración cualquiera:");
            oracion = Console.ReadLine();
            string[] partes = oracion.Split(' ');
            for (int i = 0; i < partes.Length; i++)
            {
                mayus = partes[i].Substring(0, 1).ToUpper() + partes[i].Substring(1);
                Console.Write(mayus + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
