using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Estados
    {
        private int idestado;
        private string nombreEstado;

        public Estados()
        {

        }

        public Estados(int idE, string nombreE)
        {
            idestado = idE;
            nombreEstado = nombreE;
        }
        public int idE { get; set; }
        public string nombreE { get; set; }
    }
}
