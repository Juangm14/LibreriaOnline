using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN
{
    class ENUsuario
    {
        private string email;
        private string nick;
        private string nombre;
        private string apellidos;
        private string telefono;
        private int edad;
        private string direccion;
        private string contraseña;
    }

    public ENUsuario()
    {
        Email = "";
        Nick = "";
        Nombre = "";
        Apellidos = "";
        Telefono = "";
        Edad = 0;
        Direccion = "";
        Contraseña = "";
    }

    public ENSugerencia(string email, string nick, string nombre, int edad, string telefono, string apellidos, string direccion, string contraseña)
    {
        Email = email;
        Nick = nick;
        Nombre = nombre;
        Apellidos = apellidos;
        Telefono = telefono;
        Edad = edad;
        Direccion = direccion;
        Contraseña = contraseña;
    }
}
