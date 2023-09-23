using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_A_DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class DAL_Lineas_Pedidos
    {
        DAOLineas_Pedido ado_lineas_pedidos = new DAOLineas_Pedido();
        public void insertarLineaPedido(Linea_Pedido lp)
        {
            ado_lineas_pedidos.insertarLineaPedido(lp);
        }

        public void actualizarStock(short cantidad, int idproducto)
        {
            ado_lineas_pedidos.actualizarStock(cantidad, idproducto);
        }

        public void actualizarLineaPedido(int idLineaPedido,int idProducto,short cantidad,float descuento)
        {
            ado_lineas_pedidos.actualizarLineaPedido(idLineaPedido, idProducto, cantidad, descuento);
        }

        public List<Linea_Pedido> mostrarDetallesOrdenPedido(int idLineaPedido)
        {
            return ado_lineas_pedidos.mostrarDetallesOrdenPedido(idLineaPedido);
        }

        public void eliminarLineasOrden(int idLineaPedido)
        {
            ado_lineas_pedidos.eliminarLineasOrden(idLineaPedido);
        }
        public int eliminarLineaPedido(int idLineaPedido, int idProducto)
        {
            return ado_lineas_pedidos.eliminarLineaPedido(idLineaPedido,idProducto);
        }
        }
}
