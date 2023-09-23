using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace NEGOCIO
{
    public class N_ORDER
    {
        D_ORDER norder = new D_ORDER();
        public void insertarOrder(ORDER or)
        {
            norder.insertarOrder(or);

        }

        public int mostrarOrden()
        {
            return norder.mostrarOrden();
        }

        public void borrarOrden(int or)
        {
            norder.borrarOrden(or);

        }
    }
}
