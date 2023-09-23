using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using ACCESO_A_DATOS;

namespace NEGOCIO
{
    public class DAL_Pedido
    {
        DAO_Pedido adoPedido = new DAO_Pedido();
        public void insertarPedido(Pedido p)
        {
            adoPedido.insertarPedido(p);
        }

        public int mostrarNPedido()
        {
            return adoPedido.mostrarNPedido();
        }

        public int eliminarPedido(int idPedido)
        {
           return adoPedido.eliminarPedido(idPedido);
        }
        }
}
