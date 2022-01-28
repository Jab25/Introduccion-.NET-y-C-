using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWindowsForms
{
    interface ICRUDEstatus
    {
        List<Estatus> consultar();
        Estatus consultar(int id);
        int agregar(Estatus estatus);
        void actualizar(Estatus estatus);
            void Eliminar(int id);
    }
}
