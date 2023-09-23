using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_DATOS;
using ENTITY;

namespace NEGOCIO
{
    public class DAL_Libros
    {
        DAO_Libros libros = new DAO_Libros();
        public List<string> mostrarTitulos()
        {
            return libros.mostrarTitulos();
        }

        public List<string> buscarTitulos(string texto)
        {
            return libros.buscarTitulos(texto);
        }

        public int contarLibros()
        {
            return libros.contarlibros();
        }

        public Libro mostrarDatosLibro(string titulo)
        {
            return libros.mostrarDatosLibro(titulo);
        }

        public void InsertarLibro(Libro linsertar)
        {
            libros.InsertarLibro(linsertar);

        }

        public void EliminarLibro(string idLibro)
        {
            libros.EliminarLibro(idLibro);
        }

        public void ModificarLibro(Libro lmodificar, string lcodigo)
        {
            libros.ModificarLibro(lmodificar, lcodigo);
        }

        public byte contarLibrosPorPrecio(decimal precio) {
            return libros.contarLibrosPorPrecio(precio);
        }


    }
}
