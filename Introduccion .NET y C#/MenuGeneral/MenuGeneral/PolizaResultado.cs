using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public struct PolizaResultado
    {
        public DateTime FechaTermino;
        public decimal Prima;
        public PolizaResultado(DateTime FT, decimal P)
        {
           this.FechaTermino = FT;
            this.Prima = P;
        }
    }
}
