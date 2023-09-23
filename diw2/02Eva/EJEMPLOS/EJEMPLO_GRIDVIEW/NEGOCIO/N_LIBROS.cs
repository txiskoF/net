using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{

    public class N_LIBROS
    {
        D_LIBROS nlibro = new D_LIBROS();
        public List<Libros> getLibros()
        {
            return nlibro.getLibros();
        }

        public List<Libros> getLibrosEditor(string editor)
        {
            return nlibro.getLibrosEditor(editor);
        }
        public List<Libros> getLibros(string orden)
        {
            return nlibro.getLibros(orden);
        }

        public void actualizarLibro(Libros l)
        {
            nlibro.actualizarLibro(l);
        }

        public void insertarLibro(Libros l)
        {
            nlibro.insertarLibro(l);
        }

        public void eliminarLibro(string l)
        {
            nlibro.eliminarLibro(l);
        }
    }
}
