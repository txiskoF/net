using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Usuario:Conexion
    {
        public Usuario getUsuario(string email)
        {
            Usuario u;
            SqlCommand cmdUsuario = new SqlCommand("Select * From Usuarios Where email=@email", cnn);
            cmdUsuario.Parameters.AddWithValue("@email", email);
            abrir();
            SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
            if (drUsuario.Read())
            {
                u = new Usuario(Convert.ToInt32(drUsuario[0]), drUsuario[1].ToString(),
                drUsuario[2].ToString(), drUsuario[3].ToString());
            }
            else
            {
                u = new Usuario();
            }
            drUsuario.Close();
            cmdUsuario.Dispose();
            cerrar();
            return u;
        }
        public Usuario getUsuarioSegunId(int idUsuario)
        {
            Usuario u;
            SqlCommand cmdUsuario = new SqlCommand("Select * From Usuarios Where idUsuario=@idUsuario", cnn);
            cmdUsuario.Parameters.AddWithValue("@idUsuario", idUsuario);
            abrir();
            SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
            if (drUsuario.Read())
            {
                u = new Usuario(Convert.ToInt32(drUsuario[0]), drUsuario[1].ToString(),
                drUsuario[2].ToString(), drUsuario[3].ToString());
            }
            else
            {
                u = new Usuario();
            }
            drUsuario.Close();
            cmdUsuario.Dispose();
            cerrar();
            return u;
        }

        public void insertarUsuario(Usuario u)
        {
            SqlCommand cmd = new SqlCommand("Insert into Usuarios (nombre, email, password) VALUES " +
                "(@nombre, @email, @password)", cnn);
            cmd.Parameters.AddWithValue("@nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@password", u.Password);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();
        }


    }
}
