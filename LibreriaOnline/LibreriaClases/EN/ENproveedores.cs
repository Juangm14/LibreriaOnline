using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    public class ENproveedores
    {
        private int Telefono;
        private string Email;
        private string Nombre;

        public int Telefono
        {
            get { Telefono}
            set { Telefono = value}
        }

        public string Email
        {
            get { Email}
            set { Email = value}
        }

        public string Nombre
        {
            get { Nombre}
            set { Nombre = value}
        }

        public ENproveedores()
        {
            Telefono = "";
            Email = "";
            Nombre = "";
        }

        public ENproveedores(int telefono, string email, string nombre)
        {
            Telefono = telefono;
            Email = email;
            Nomber = nombre;
        }

        public bool LicenciaProveedores()
        {
            CADproveedores c1 = new CADproveedores();
            return c1.LicenciaProveedores(this);
        }
        public bool AdministraLibros()
        {
            CADproveedores c1 = new CADproveedores();
            return c1.AdministraLibros(this);
        }

    }

}
