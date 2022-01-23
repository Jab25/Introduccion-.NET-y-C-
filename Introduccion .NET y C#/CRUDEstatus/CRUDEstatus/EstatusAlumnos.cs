using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class EstatusAlumnos
    {
        struct Estatus
        {
            public int ID;
            public String nombre;
            public Estatus(int Id, string Status)

            {
                ID = Id;
                nombre = Status;
            }
        }
        private static List<Estatus> _lstcrudEstatus = new List<Estatus>();
        static void Main(string[] args)
        {
            Boolean f = false;
            string eleg;
            while (!f)
            {
                Console.WriteLine("\n 1. Consultar Todos \n 2.Consultar Solo uno \n 3.Agregar " +
                    "\n 4.Actualizar \n 5.Eliminar \n 6.Terminar \n");

                Console.WriteLine("Seleccione una opción");
                eleg = Console.ReadLine();

                if (eleg.Equals("1"))
                {
                    EstatusAlumnos EA = new EstatusAlumnos();
                    EA.MostrarTodos();
                }
                else if (eleg.StartsWith("2"))
                {
                    Console.WriteLine(" Que Id estas buscando ");
                    int id = int.Parse(Console.ReadLine());
                    EstatusAlumnos EA = new EstatusAlumnos();
                    EA.MostrarSoloUno(id);
                }
                else if (eleg.Equals("3"))
                {
                    EstatusAlumnos EA = new EstatusAlumnos();
                    EA.Insertar();
                }
                else if (eleg.StartsWith("4"))
                {
                    Console.WriteLine(" Que Id estas buscando para actualiza: ");
                    int idEstatus = int.Parse(Console.ReadLine());
                    EstatusAlumnos EA = new EstatusAlumnos();
                    Console.WriteLine("Ingrese el nuevo datos: ");
                    string valorNuevo = Console.ReadLine();
                    EA.Actualizar(idEstatus, valorNuevo);
                }
                else if (eleg.Equals("5"))
                {
                    Console.WriteLine(" Que Id estas buscando para eliminar: ");
                    int idEstatus = int.Parse(Console.ReadLine());
                    EstatusAlumnos EA = new EstatusAlumnos();
                    EA.Eliminar(idEstatus);
                }
                else if (eleg.StartsWith("6"))
                    Environment.Exit(0);
                else
                    Console.WriteLine("\nNo se encontro la eleccion\n");
            }
            Console.ReadKey();
        }

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

                    _lstcrudEstatus.Add(new Estatus { ID = id, nombre = desc });

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
        public void MostrarTodos()
        {
            try
            {
                foreach (var oEstatus in _lstcrudEstatus)
                {
                    Console.Write($"{oEstatus.ID} {oEstatus.nombre} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void MostrarSoloUno(int idestatus)
        {
            try
            {
                Estatus st2 = _lstcrudEstatus.Find(status => status.ID == idestatus);
                Console.WriteLine($"id=>{st2.ID}, Estatus=>{st2.nombre}");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Al parecer el Estatus no Existe!!");
            }
        }
        public void Actualizar(int idEstatus, string valorNuevo)
        {
            try
            {
                Estatus st1 = _lstcrudEstatus.Find(status => status.ID == idEstatus);
                st1.nombre = valorNuevo;

                Console.WriteLine(" Se Actualizó de manera Exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Eliminar(int idEstatus)
        {
            try
            {
                _lstcrudEstatus.RemoveAll(x => x.ID == idEstatus);
                Console.WriteLine("Eliminado Correctamente!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
