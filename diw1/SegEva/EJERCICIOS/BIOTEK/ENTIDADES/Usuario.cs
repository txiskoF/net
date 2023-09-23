using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Usuario
    {
        int idUsuario;
        string nombre;
        string email;
        string password;

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombre, string email, string password)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
