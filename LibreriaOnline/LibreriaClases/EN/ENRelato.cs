using LibreriaClases.CAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.EN {
    public class ENRelato {

        private string email;

        public ENRelato(string email) {
            this.email = email;
        }

        public string getEmail() {
            return email;
        }
        public DataSet ListarRelato() {
            CADRelato cad = new CADRelato();
            return cad.ListarRelatos(this);
        }
    }
}
