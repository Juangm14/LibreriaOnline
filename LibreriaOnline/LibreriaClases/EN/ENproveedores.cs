using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.EN;

namespace LibreriaOnline
{
    public class ENProveedores
    {
        private string Email;
        private string Nombre;
        private int Telefono;
        private char TipoLibro;
        private string Contraseña;

        public void setEmail(string email)
        {
            Email = email;
        }
        public string getEmail()
        {
            return Email;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setTelefono(int telefono)
        {
            Telefono = telefono;
        }
        public int getTelefono()
        {
            return Telefono;
        }

        public void setTipoLibro(char tipo)
        {
            TipoLibro = tipo;
        }
        public char getTipoLibro()
        {
            return TipoLibro;
        }

        public void setContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }
        public string getContraseña()
        {
            return Contraseña;
        }

        public ENProveedores()
        {
            Email = "";
            Nombre = "";
            Telefono = 0;
            TipoLibro = 'F';
            Contraseña = "";
        }

        public ENProveedores(string email, string nombre, int telefono, string tipolibro, string contraseña)
        {
            Email = email;
            Nombre = nombre;
            Telefono = telefono;
            if (tipolibro.Equals("Físico"))
            {
                TipoLibro = 'F';
            }
            else
            {
                TipoLibro = 'O';
            }
            Contraseña = contraseña;

        }
        public bool CrearProveedor()
        {
            CADProveedores cad = new CADProveedores();
            if (cad.ExisteEmail(this))
            {
                return cad.Registrar(this);
            }
            else
            {
                return false;
            }
        }
        public bool EmailRepetido()
        {
            CADProveedores cad = new CADProveedores();
            return cad.ExisteEmail(this);
        }

        public bool Log()
        {
            ENProveedores verificar = new ENProveedores();
            CADProveedores cad = new CADProveedores();
            if (cad.ExisteEmail(this))
            {
                verificar.setEmail(Email);
                cad.ReadEmail(verificar);
                if (verificar.Contraseña == Contraseña)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool Registrar()
        {
            CADProveedores registro = new CADProveedores();
            if (!(registro.ExisteEmail(this)))
            {
                return registro.CrearProveedor(this);
            }
            else
            {
                return false;
            }
        }

        public bool ModificarProveedor()
        {
            return true;
        }
        public bool EliminarProveedor()
        {
            return false;
        }
    }
}
