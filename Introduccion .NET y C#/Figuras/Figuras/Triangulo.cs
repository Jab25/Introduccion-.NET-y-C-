using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo : iFiguras
    {
        public decimal Lado { get; set; }
        public decimal Area()
        {
            return (Lado * Lado) / 2;
        }

        public decimal Perimetro()
        {
            return Lado * 3;
        }
    }
}
