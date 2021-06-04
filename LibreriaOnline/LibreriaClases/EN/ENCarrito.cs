using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClases.CAD;

namespace LibreriaClases.EN {
    public class ENCarrito {

        public string _ISBN;
        public string ISBN {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        private string _Usuario;

        public string Usuario{
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Cantidad;

        public string Cantidad {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public ENCarrito(string ISBN, string email) {
            this.ISBN = ISBN;
            Usuario = email;
            Cantidad = "1";
        }
        public ENCarrito(string ISBN, string email, string cantidad) {
            this.ISBN = ISBN;
            Usuario = email;
            Cantidad = cantidad;
        }

        public ENCarrito(string email) {
            this.Usuario = email;
        }

        public bool agregarElementoCarrito() {
            CADCarrito cad = new CADCarrito();
            return cad.agregarElementoCarrito(this);
        }

        public DataSet listarElementosCarrito() {
            CADCarrito cad = new CADCarrito();
            return cad.listarElementosCarrito(this);
        }
        public bool eliminarElementoCarrito() {
            CADCarrito cad = new CADCarrito();
            return cad.eliminarElementoCarrito(this);
        }

        public bool modificarElementoCarrito() {
            CADCarrito cad = new CADCarrito();
            return cad.modificarElementoCarrito(this);
        }
    }
}
