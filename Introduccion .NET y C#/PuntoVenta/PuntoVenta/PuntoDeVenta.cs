using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class PuntoDeVenta
    {
        
        List<Articulos> _ListArticulos = new List<Articulos>();
        List<ItemBase> _ListItemBase = new List<ItemBase>();
        int _totalVentas;
        decimal _totalVendido, _totalDescuento, _totalComisiones, _totalGeneral;

        public void IniciarVentas()
        {
            StreamReader ArticulosJSON = new StreamReader(@"C:\Users\Tichs\Documents\Capacitacion JOM\introduccion .NET\Articulos.json");
            string DatosArticulos = ArticulosJSON.ReadToEnd();
            ArticulosJSON.Close();
            _ListArticulos = JsonConvert.DeserializeObject<List<Articulos>>(DatosArticulos);
        }

        public void Ventas()
        {
            String continuar;
            do
            {
                venta();

                Console.WriteLine("Desea realiza mas ventas: ");
                continuar = Console.ReadLine();
            } while (continuar.ToUpper() == "SI");
            _totalVentas++;
            ImprimirTicket();                  
        }
        
        private void venta()
        {
          String agregar;
            do
            {
              
                Console.WriteLine("Desea agregar otro articulo: ");
                agregar = Console.ReadLine();
                AgregarArticulo();
            } while (agregar.ToUpper() == "SI");

        }

        private void AgregarArticulo()
        {
            Console.WriteLine("Ingrese el Id del Articulo: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de artículo: ");
            int cant = int.Parse(Console.ReadLine());

            Articulos articulos = _ListArticulos.Find(x => x.Id == id);

            switch(articulos.tipo)
            {
                case TipoArticulo.normal:
                    ArticuloNormal(articulos, cant);
                    break;
                case TipoArticulo.conDescuento:
                    ArticuloDescuento(articulos, cant);
                    break;
                case TipoArticulo.tiempoAire:
                    ArticuloTA(articulos, cant);
                    break;
            }
        }

        private void ArticuloNormal(Articulos articulos, int cant)
        {
            Item articulonormal = new Item();
            articulonormal.Id = articulos.Id;
            articulonormal.Nombre = articulos.Nombre;
            articulonormal.Precio = articulos.Precio;
            articulonormal.Cantidad = cant;
            _ListItemBase.Add(articulonormal);
            _totalVendido += articulonormal.Cantidad;
        }

        private void ArticuloDescuento(Articulos articulos, int cant)
        {
            Console.WriteLine("Ingrese el descuento del articulo: ");
            decimal Descuento = decimal.Parse(Console.ReadLine());
            ItemDescuento articulodescuento = new ItemDescuento();
            articulodescuento.Id = articulos.Id;
            articulodescuento.Nombre = articulos.Nombre;
            articulodescuento.Precio = articulos.Precio;
            articulodescuento.Cantidad = cant;
            articulodescuento.Descuento = Descuento;
            _ = articulodescuento.ImpDescuento;
            _ListItemBase.Add(articulodescuento);
            _totalDescuento += articulodescuento.Descuento;
        }

        private void ArticuloTA(Articulos articulos, int cant)
        {
            Console.WriteLine("Ingrese los datos del Tiempo aire: ");
            Console.WriteLine("Ingrese Numero de telefono: ");
            string Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese Compañia Telefonica: ");
            string Compañia = Console.ReadLine();
            Console.WriteLine("Ingrese Comision: ");
            decimal Comision = decimal.Parse(Console.ReadLine());
            ItemTA articuloTA = new ItemTA();
            articuloTA.Id = articulos.Id;
            articuloTA.Nombre = articulos.Nombre;
            articuloTA.Precio = articulos.Precio;
            articuloTA.Cantidad = cant;
            articuloTA.Telefono = Telefono;
            articuloTA.Compañia = Compañia;
            articuloTA.Comision = Comision;
            _ListItemBase.Add(articuloTA);
            _totalComisiones += articuloTA.Comision;
        }

        private void ImprimirTicket()
        {
            Console.WriteLine("TICH - TI CAPITAL HUMANO");
            Console.WriteLine("Fecha y hora: " + DateTime.Now);
            foreach (var art in _ListItemBase)
            {
                art.Imprimir();
            }
            Console.WriteLine("Total de articulos: " + _ListItemBase.Count());
            Console.WriteLine("Total a pagar: " + _ListItemBase.Sum(suma => suma.Precio));
            _totalVendido += _ListItemBase.Sum(suma => suma.Precio);
        }

        public void CorteCaja()
        {
            _totalGeneral = _totalVendido + _totalComisiones - _totalDescuento;
            Console.WriteLine("\n Corte de caja: ");
            Console.WriteLine("Total de ventas: " + _totalVentas);
            Console.WriteLine("Importe vendido: " + _totalVendido);
            Console.WriteLine("Total descuento: " + _totalDescuento);
            Console.WriteLine("Total comisiones: " + _totalComisiones);
            Console.WriteLine("Total en caja: " + _totalGeneral);
            Console.ReadKey();
        }
    }
}
