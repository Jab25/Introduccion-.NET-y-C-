using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemTA:ItemBase
    {
        public string Telefono { get; set; }
        public string Compañia { get; set; }
        public decimal Comision { get; set; }

        public override decimal total()
        {
            return base.subtotal() + this.Comision;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Id} {Nombre} {Precio} {Cantidad} {subtotal()}");
            Console.WriteLine($"Telefono: {Telefono}% \n" +
                              $"Copañia: {Compañia}\n" +
                              $"Comision: {Comision}\n" +
                              $"Total: {total()}");
        }
    }
}
