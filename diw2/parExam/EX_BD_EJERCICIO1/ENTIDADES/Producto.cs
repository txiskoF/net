using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Producto
    {
        int idProducto;
        string descripcion;
        decimal precio;
        short unidadesEnStock;
        short unidadesEnPedido;
        Boolean discontinuo;

        public Producto(int idProducto, string descripcion, decimal precio, short unidadesEnStock, short unidadesEnPedido, bool discontinuo)
        {
            this.IdProducto = idProducto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.UnidadesEnStock = unidadesEnStock;
            this.UnidadesEnPedido = unidadesEnPedido;
            this.Discontinuo = discontinuo;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public short UnidadesEnStock { get => unidadesEnStock; set => unidadesEnStock = value; }
        public short UnidadesEnPedido { get => unidadesEnPedido; set => unidadesEnPedido = value; }
        public bool Discontinuo { get => discontinuo; set => discontinuo = value; }
    }
}
