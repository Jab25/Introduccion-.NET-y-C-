using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Item : ItemBase
    {
        public override void Imprimir()
        {
            Console.WriteLine($"-+-+-+-+-+-+-+-+-+-+\n" +
                              $"|{Id} {Nombre} {Precio} {Cantidad} |\n" +
                              $"|{subtotal()} |\n" +
                              $"+-+-+-+-+-+-+-+-+-+-+|");
            Console.WriteLine($"Total: {total()}");
        }
    }
}
