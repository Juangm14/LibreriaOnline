using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.CAD;

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

    public ENUsuario(string email, string nick, string nombre, int edad, string telefono, string apellidos, string direccion, string contraseña)
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
    public bool modificardatosUsuario()
    {
        CADUsuario u=new CADUsuario
            return u.modificarUsuario(this);
    }

    public bool relatosUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.relatosUsuario(this);
    }

    public bool readrelatosUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.readrelatosUsuario(this);
    }

    public bool deleterelatosUsuario()
    {
        CADUsuario u= new CADUsuario
            return u.deleterelatosUsuario(this);
    }

    public bool venderUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.venderUsuario(this);
    }

    public bool deletevenderUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.deletevenderUsuario(this);
    }

    public bool recomendarlibrosUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.recomendarlibrosUsuario(this);
    }

    public bool criticaUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.criticaUsuario(this);
    }
    
    public bool readcriticaUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.readcriticaUsuario(this);
    }

    public bool deletecriticaUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.deletecriticaUsuario(this);
    }
    public bool createUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.readUsuario(this);
    }

    public bool readUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.modificarUsuario(this);
    }

    public bool deleteUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.deleteUsuario(this);
    }

    public bool updateUsuario()
    {
        CADUsuario u = new CADUsuario
            return u.updateUsuario(this);
    }
    }

