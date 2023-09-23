using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Linea_Pedido
    {
        int idPedido;
        int idProducto;
        decimal precio;
        short cantidad;
        float descuento;

        public Linea_Pedido(int idPedido, int idProducto, decimal precio, short cantidad, float descuento)
        {
            this.IdPedido = idPedido;
            this.IdProducto = idProducto;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Descuento = descuento;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public short Cantidad { get => cantidad; set => cantidad = value; }
        public float Descuento { get => descuento; set => descuento = value; }
    }
}
