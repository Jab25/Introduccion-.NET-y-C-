using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemDescuento:ItemBase
    {
        public decimal Descuento { get; set; }
        public decimal ImpDescuento {
            get
            {
                return Precio * Cantidad * Descuento/100;
            }
        }

        public override decimal total()
        {
            return base.subtotal() - this.ImpDescuento;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Id} {Nombre} {Precio} {Cantidad} {subtotal()}");
            Console.WriteLine($"Descuento: {Descuento}% \n" +
                              $"Importe: {ImpDescuento}\n" +
                              $"Total: {total()}");
        }
    }
}
