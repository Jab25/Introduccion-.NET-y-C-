using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public virtual decimal subtotal() => Precio * Cantidad;
        public virtual decimal total() => Precio * Cantidad;
        public abstract void Imprimir();
    }
}
