using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ADOEstatus ado = new ADOEstatus();
            string opcion;
            do
            {
                Console.WriteLine("1. Consultar Todos \n"+
                                  "2. Consultar Solo uno \n"+
                                  "3. Agregar \n"+
                                  "4. Actualizar \n"+
                                  "5. Eliminar \n"+
                                  "6. Terminar");
                Console.WriteLine("Elije una opcion");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        foreach (var i in ado.consultar())
                        {
                            Console.WriteLine($"ID = {i.id} Clave= {i.Clave} Nombre = {i.Nombre}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el Id del Estatus a Buscar:");
                        int id = int.Parse(Console.ReadLine());
                        var item = ado.consultar(id);
                        Console.WriteLine($"ID= {item.id} Clave= {item.Clave} Nombre= {item.Nombre}");
                        break;
                    case "3":
                        Console.WriteLine("Ingresa la Clave del Estatus");
                        string clave = Console.ReadLine();
                        Console.WriteLine("Ingresa la descripcion del Estatus:");
                        string nombreE = Console.ReadLine();
                        Estatus estatus = new Estatus {Clave = clave, Nombre = nombreE };
                        var it = ado.agregar(estatus);
                        Console.WriteLine($"ID= {it}");
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el Id del Estatus a Actualizar:");
                        int idA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el Nombre del Estatus:");
                        string clavA = Console.ReadLine();
                        Console.WriteLine("Ingresa la Dscripcion del Estatus:");
                        string descrA = Console.ReadLine();
                        Estatus estatusA = new Estatus { id = idA, Clave = clavA, Nombre = descrA };
                        ado.actualizar(estatusA);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el Id del Estatus a Eliminar:");
                        int idE = int.Parse(Console.ReadLine());
                        ado.Eliminar(idE);
                       break;
                }
            } while (opcion != "6");
        }
    }
}