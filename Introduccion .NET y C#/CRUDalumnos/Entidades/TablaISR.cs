using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TablaISR
    {
        public decimal límiteinferior { get; set; }
        public decimal límitesuperior { get; set; }
        public decimal cuotaFija { get; set; }
        public decimal excedente { get; set; }
        public decimal subsidio { get; set; }
        public decimal impuesto { get; set; }
    }
}
