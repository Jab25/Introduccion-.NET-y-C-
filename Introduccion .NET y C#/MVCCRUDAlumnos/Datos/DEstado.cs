using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstado
    {
        private CapacitacionEntities db = new CapacitacionEntities();
        public List<Estados> consultar()
            {
                List<Estados> cons = db.Estados.ToList();
            return cons;
            }
    }
}
