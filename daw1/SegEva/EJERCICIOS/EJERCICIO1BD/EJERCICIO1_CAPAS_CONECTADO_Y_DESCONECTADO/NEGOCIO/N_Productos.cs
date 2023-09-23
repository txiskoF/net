using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace NEGOCIO
{
    public class N_Productos
    {
        D_Productos nproducto = new D_Productos();
        public List<Productos> mostrarProductos()
        {
            return nproducto.mostrarProductos();
        }

        public Productos mostrarProducto(string descripcion)
        {

            return nproducto.mostrarProducto(descripcion);
        }


        public void actualizarProducto(string productID, int cantidad)
        {
            nproducto.actualizarProducto(productID, cantidad);
        }
    }
}

