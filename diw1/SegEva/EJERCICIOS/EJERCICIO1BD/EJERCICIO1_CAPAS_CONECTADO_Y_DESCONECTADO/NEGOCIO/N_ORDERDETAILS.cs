using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace NEGOCIO
{
  
   
    public class N_ORDERDETAILS
    {
        D_ORDERDETAILS norderdetails = new D_ORDERDETAILS();

        public void insertarOrderDetail(ORDERDETAILS or)
        {
            norderdetails.insertarOrderDetail(or);
        }
        public short mostrarCantidad(ORDERDETAILS or)
        {
            return norderdetails.mostrarCantidad(or);
        }
            public void actualizarLineaPedido(ORDERDETAILS or)
        {
            norderdetails.actualizarLineaPedido(or);
        }
            public List<ORDERDETAILS> mostrarDetallesORden(int ordenID)
        {
            return norderdetails.mostrarDetallesORden(ordenID);
        }


        public void borrarOrden(int orden,int producto)
        {
            norderdetails.borrarOrden(orden,producto);
        }

        public void borrarOrden(int orden)
        {
            norderdetails.borrarOrden(orden);
        }
        }
}
