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

        public void EliminarLibro(string title_id)
        {
            libros.EliminarLibro(title_id);
        }
        public void ActualizarLibro(Libro linsertar)
        {
            libros.ActualizarLibro(linsertar);
        }
        public List<Libro> getLibros(string expresion)
        {
            return libros.getLibros(expresion);
        }
        public List<string> mostrarTitulos()
        {
            return libros.mostrarTitulos();
        }

        public List<string> buscarTitulos(string texto)
        {
            return libros.buscarTitulos(texto);
        }
        public int contarlibros()
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
    }
}
