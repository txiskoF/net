using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Usuario
    {
        DAO_Usuario DUsuario = new DAO_Usuario(); 


        public Usuario getUsuario(string email)
        {
            return DUsuario.getUsuario(email);
        }

        public void insertarUsuario(Usuario u)
        {
            DUsuario.insertarUsuario(u);
        }

        public Usuario getUsuarioSegunId(int idUsuario)
        {
            return DUsuario.getUsuarioSegunId(idUsuario);
        }
    }
}
