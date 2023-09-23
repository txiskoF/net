using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using ACCESO_A_DATOS;


namespace NEGOCIO
{
    public class DAL_Producto
    {
        DAO_Producto adoProducto = new DAO_Producto();
        public List<Producto> mostrarProductos()
        {
            return adoProducto.mostrarProductos();
        }

        public Producto mostrarDatosProducto(int idproducto)
        {
            return adoProducto.mostrarDatosProducto(idproducto);
        }
        }
}
