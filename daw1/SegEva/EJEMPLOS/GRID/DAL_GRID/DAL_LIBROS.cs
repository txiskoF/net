using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_GRID;
using ENTIDADES_GRID;

namespace DAL_GRID
{
    public class DAL_LIBROS
    {
        DAO_LIBROS dLibro = new DAO_LIBROS();
        DAO_Editores dEditor = new DAO_Editores();
        public List<LIBROS> getLibros()
        {
            return dLibro.getLibros();
        }

        public void updateLibros(LIBROS l)
        {
            dLibro.updateLibros(l);
        }

        public void deleteLibro(string id)
        {
            dLibro.deleteLibro(id);
        }

        public void insertLibro(LIBROS l)
        {
            dLibro.insertLibro(l);

        }

        public List<LIBROS> seleccionLibros(string orden)
        {
            return dLibro.seleccionLibros(orden);

        }

        public List<Editor> getEditores()
        {
            return dEditor.getEditores();
        }

        public List<LIBROS> getLibrosEditor(string editor)
        {
            return dLibro.getLibrosEditor(editor);
        }
    }
}
