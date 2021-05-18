using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    public class ENproveedores
    {
        private int Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public ENproveedores()
        {
            Telefono = 0;
            Email = "";
            Nombre = "";
        }

        public ENproveedores(int telefono, string email, string nombre)
        {
            Telefono = telefono;
            Email = email;
            Nombre = nombre;
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
