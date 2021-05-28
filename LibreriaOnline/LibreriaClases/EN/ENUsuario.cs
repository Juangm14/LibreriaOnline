using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.CAD;

namespace LibreriaOnline.EN
{
    public class ENUsuario {
        private string email;
        private string nick;
        private string nombre;
        private string apellidos;
        private string telefono;
        private int edad;
        private string direccion;
        private string contraseña;
        private string text;
        private string v1;
        private int v2;

        public ENUsuario(string usuario) {
            email = usuario;
            nick = "";
            nombre = "";
            apellidos = "";
            telefono = "";
            edad = 0;
            direccion = "";
            contraseña = "";
        }

        public ENUsuario()
        {
            email = null;
            nick = "";
            nombre = "";
            apellidos = "";
            telefono = "";
            edad = 0;
            direccion = "";
            contraseña = "";
        }

        public ENUsuario(string direccionn, string nickk, string telefonoo, string contraseñaa,string usuario)
        {
            
            telefono = telefonoo;
            email = usuario;
            direccion = direccionn;
            contraseña = contraseñaa;
            nick = nickk;
        }

        public ENUsuario(string email, string nick, string nombre, int edad, string telefono, string apellidos, string direccion, string contraseña) {
            this.email = email;
            this.nick = nick;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.edad = edad;
            this.direccion = direccion;
            this.contraseña = contraseña;
        }

       
        
        public string email_
        {
            get { return email; }
            set { email = value; }
        }
        public bool modificardatosUsuario() {
            CADUsuario u = new CADUsuario();
            return u.modificarUsuario(this);
        }

        public System.Data.SqlClient.SqlDataReader mostrardatos()
        {
            CADUsuario u = new CADUsuario();
            return u.mostrardatos(this);
        }
        public string getDireccion()
        {
            return direccion;
        }
        public string getNick()
        {
            return nick;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public string getContraseña()
        {
            return contraseña;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email) { this.email = email; }

       
        public bool createUsuario() {
            CADUsuario u = new CADUsuario();
            return u.readUsuario(this);
        }

        public bool readUsuario() {
            CADUsuario u = new CADUsuario();
            return u.modificarUsuario(this);
        }

        public bool deleteUsuario() {
            CADUsuario u = new CADUsuario();
                return u.deleteUsuario(this);
        }

        public bool updateUsuario() {
            CADUsuario u = new CADUsuario();
                return u.updateUsuario(this);
        }
    }
}

