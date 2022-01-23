using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Estatus
    {
        struct EstatusN
        {
            public int ID;
            public String nombre;
            public EstatusN(int Id, string Status)

            {
                ID = Id;
                nombre = Status;
            }
        }
        private static List<EstatusN> _lstinsEstatus = new List<EstatusN>();
        
        public void Insertar()
        {
            try
            {
                string afir;
                do
                {
                    Console.WriteLine("\nIngrese el id del Estatus:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nIngrese el Estatus:");
                    string desc = Console.ReadLine();

                    _lstinsEstatus.Add(new EstatusN { ID = id, nombre = desc });

                    Console.WriteLine("\nDesea agregar otro Estatus?: y/n...");
                    afir = Console.ReadLine();
                } while (afir != "n");
                Console.WriteLine("Registro Exitoso: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
