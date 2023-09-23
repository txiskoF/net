using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
[Serializable]
public class Usuario
{
    string login;
    string password;
    public Usuario()
    {

    }

    public Usuario(string login, string password)
    {
        this.login = login;
        this.password = password;
    }

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            login = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }
}