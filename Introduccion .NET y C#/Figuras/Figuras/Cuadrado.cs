using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado:iFiguras
    {
        public decimal Lado;

        public decimal Area()
        {
            return Lado * Lado;
        }

        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
