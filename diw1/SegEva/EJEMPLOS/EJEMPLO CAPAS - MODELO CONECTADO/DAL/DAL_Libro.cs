using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAO;

namespace DAL
{
    public class DAL_Libro
    {
        DAO_Libro DLibro = new DAO_Libro();

        public List<string> getLibros()
        {
            return DLibro.getLibros();
        }

        public Libro getLibro(string titulo)
        {
            return DLibro.getLibro(titulo);
        }
        public int totalLibros()
        {
            return DLibro.totalLibros();
        }

        public void insertarLibro(Libro linsertar)
        {
            DLibro.insertarLibro(linsertar);
        }
        public void modificarLibro(Libro lmodificar)
        {
            DLibro.modificarLibro(lmodificar);

        }
        public void eliminarLibro(string leliminar)
        {
            DLibro.eliminarLibro(leliminar);
        }
    }
}