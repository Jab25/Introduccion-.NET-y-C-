using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace LINQ
{
    internal class OperacionesLINQ
    {
        public void Consultas()
        {
            StreamReader AlumnosJSON = new StreamReader("C:\\Users\\Tichs\\Documents\\Capacitacion JOM\\introduccion .NET\\Alumnos.json");
            string DatosALumnos = AlumnosJSON.ReadToEnd();
            AlumnosJSON.Close();
            List<Alumnos> _listAlumnos = JsonConvert.DeserializeObject<List<Alumnos>>(DatosALumnos);

            StreamReader EstadosJSON = new StreamReader("C:\\Users\\Tichs\\Documents\\Capacitacion JOM\\introduccion .NET\\Estados.json");
            string DatosEstados = EstadosJSON.ReadToEnd();
            EstadosJSON.Close();
            List<Estados> _listEstados = JsonConvert.DeserializeObject<List<Estados>>(DatosEstados);

            StreamReader EstatusJSON = new StreamReader("C:\\Users\\Tichs\\Documents\\Capacitacion JOM\\introduccion .NET\\Estatus.json");
            string DatosEstatus = EstatusJSON.ReadToEnd();
            EstatusJSON.Close();
            List<Estatus> _listEstatus = JsonConvert.DeserializeObject<List<Estatus>>(DatosEstatus);

            StreamReader ArchivoISR = new StreamReader(@"C:\Users\Tichs\Documents\Capacitacion JOM\SQL\TablaISR.csv");
            List<ItemISR> _listISR = new List<ItemISR>();
            var csv = new CsvReader(ArchivoISR, CultureInfo.InvariantCulture);
            _listISR = csv.GetRecords<ItemISR>().ToList();

            //De la lista de estados, obtener el estado que tiene el id = 5
            var EstadoId5 = from Estados in _listEstados
                            where Estados.idE == 5
                            select Estados;
            foreach (var Esta5 in EstadoId5)
            {
                Console.WriteLine($"ID: {Esta5.idE} Nombre {Esta5.nombreE}");
            }

            //con lamda
            //var EstadoId5Lamda = _listEstados.All(estado => estado.idE == 5);
            //Console.WriteLine(EstadoId5Lamda);

            //De la lista de alumnos obtener a los alumnos cuyo idEstado 29 y 13, Ordenado por nombre
            var Alumnos2913 = from Alumnos in _listAlumnos
                              where Alumnos.idEstado == 29 || Alumnos.idEstado == 13
                              orderby Alumnos.nombre descending
                              select Alumnos;
            foreach (var alum in Alumnos2913)
            {
                Console.WriteLine($"ID: {alum.id} Nombre {alum.nombre} Calificacion: {alum.calificacion} Estaus: {alum.idEstatus} Estado: {alum.idEstado}");
            }

            //De la lista de alumnos obtener los alumnos que son IdEstado 19 y 20 y además de que estén en el estatus 4 o 5
            var Alumnos1920 = from Alumnos in _listAlumnos
                              where Alumnos.idEstado == 19 || Alumnos.idEstado == 20
                                 && Alumnos.idEstatus == 4 || Alumnos.idEstatus == 5
                              orderby Alumnos.nombre descending
                              select Alumnos;
            foreach (var alum2 in Alumnos1920)
            {
                Console.WriteLine($"ID: {alum2.id} Nombre {alum2.nombre} Calificacion: {alum2.calificacion} Estaus: {alum2.idEstatus} Estado: {alum2.idEstado}");
            }

            //Obtener una lista de los alumnos que tienen calificación aprobatoria, considerando esta como 6 o mayor, ordenado por calificación del mayor al menor 
            var AlumnosAprov = from Alumnos in _listAlumnos
                               where Alumnos.calificacion >= 6
                               orderby Alumnos.calificacion descending
                               select Alumnos;
            foreach (var aprov in AlumnosAprov)
            {
                Console.WriteLine($"ID: {aprov.id} Nombre {aprov.nombre} Calificacion: {aprov.calificacion} Estaus: {aprov.idEstatus} Estado: {aprov.idEstado}");

            }

            //Obtener la calificación promedio de los alumnos
            Console.WriteLine($"Promedio: {_listAlumnos.Average(a => a.calificacion)}\n");

            //En caso de que ningún alumno tenga 10, sumarles un punto de calificación, y en caso de que todos estén entre 6 y 7 sumarles dos puntos.
            foreach (var itemCal in AlumnosAprov)
            {
                if (itemCal.calificacion >= 6 && itemCal.calificacion <= 7)
                {
                    Console.WriteLine($"Alumnos entre 6 y 7: {itemCal.nombre}, calificacion: {itemCal.calificacion + 2}");
                }
                else if (itemCal.calificacion > 8 && itemCal.calificacion < 10)
                {
                    Console.WriteLine($"Alumnos entre que no tienen 10: {itemCal.nombre}, calificacion: {itemCal.calificacion + 1}");
                }
            }

            //Mostar en la consola los siguientes datos, de aquellos alumnos que estén en estatus 3:
            /* • idAlumnos, • nombreAlumno, • nombre del Estado al que pertenece*/
            var AlumnosEstatus3 = from Alumnos in _listAlumnos
                                  where Alumnos.idEstado == 3
                                  join Estado in _listEstados on Alumnos.idEstado equals Estado.idE
                                  select (Alumnos.id, Alumnos.nombre, Estado.nombreE);
            foreach (var Esta3 in AlumnosEstatus3)
            {
                Console.WriteLine(Esta3);
            }

            //Mostar en la consola los siguientes datos, de aquellos alumnos que estén en estatus 2, ordenado por nombre del Alumno:
            /* • idAlumnos, • nombreAlumno, • nombre del Estatus en que se encuentran*/
            var AlumnosEstatus2 = from Alumnos in _listAlumnos
                                  where Alumnos.idEstatus == 2
                                  orderby Alumnos.nombre
                                  join Estatus in _listEstatus on Alumnos.idEstatus equals Estatus.idEsta
                                  select (Alumnos.id, Alumnos.nombre, Estatus.nombreEstatus);
            foreach (var Esta2 in AlumnosEstatus2)
            {
                Console.WriteLine(Esta2);
            }

            //Mostar en la consola los siguientes datos, de aquellos alumnos cuyo estatus sea mayor a 2, ordenado por nombre del estatus:
            /* • idAlumnos, • nombreAlumno, • nombre del Estado al que pertenece, • nombre del Estatus en que se encuentran*/
            var AlumnosEstatusMay2 = from Alumnos in _listAlumnos
                                     where Alumnos.idEstatus > 2
                                     join Estatus in _listEstatus on Alumnos.idEstatus equals Estatus.idEsta
                                     join Estado in _listEstados on Alumnos.idEstado equals Estado.idE
                                     orderby Estatus.nombreEstatus
                                     select (Alumnos.id, Alumnos.nombre, Estado.nombreE, Estatus.nombreEstatus);
            foreach (var Esta2 in AlumnosEstatusMay2)
            {
                Console.WriteLine(Esta2);
            }

            // Calcular el impuesto para un sueldo mensual de 22,000, y mostrarlo en la consola:
            /* • La búsqueda en la tablaISR de los parámetros correspondientes para el cálculo del ISR deben de ser a través de LINQ*/
            var calculoISR = from isr in _listISR
                             where isr.LimInf == 11951.86m && isr.LimSup == 18837.75m
                             select new
                             {
                                 sueldoQuincenal = 22000.00m / 2,
                                 cuotaf = isr.Cuotafija,
                                 porExce = isr.PorExced,
                                 subsidio = isr.Subsidio,
                                 Impuesto = ((((22000.00m / 2) - isr.LimInf) * (isr.PorExced / 100)) + isr.Cuotafija) - isr.Subsidio
                             };
            Console.WriteLine("Calculo de impuesto por un sueldo de 22,000.00 Mensual...");
            foreach (var itemisr in calculoISR)
            {
                Console.WriteLine($"Sueldo Quincenal= {itemisr.sueldoQuincenal}, Cuota Fija= {itemisr.cuotaf}, % Excedente= {itemisr.porExce}, " +
                    $"Subsidio= {itemisr.subsidio}, Impuesto a pagar= {itemisr.Impuesto}");

            }
        }
    }
}
