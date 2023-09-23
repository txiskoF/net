using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Productos
    {
        int idProducto;
        string descripcion;
        decimal precio;
        int unidadesenstock;
        int unidadesenpedido;

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Unidadesenstock
        {
            get
            {
                return unidadesenstock;
            }

            set
            {
                unidadesenstock = value;
            }
        }

        public int Unidadesenpedido
        {
            get
            {
                return unidadesenpedido;
            }

            set
            {
                unidadesenpedido = value;
            }
        }

        public Productos() { }

        public Productos(int idProducto, string descripcion, decimal precio, int unidadesenstock, int unidadesenpedido)
        {
            this.IdProducto = idProducto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Unidadesenstock = unidadesenstock;
            this.Unidadesenpedido = unidadesenpedido;
        }
    }
}
