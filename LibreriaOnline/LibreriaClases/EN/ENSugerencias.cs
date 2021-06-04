using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    public class ENSugerencias {
        private string titulo;
        private string texto;
        private int id;
        private string asunto;


        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Texto {
            get { return texto; }
            set { texto = value; }
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Asunto {
            get { return asunto; }
            set { asunto = value; }
        }

        public ENSugerencias() {
            Titulo = "";
            Texto = "";
            Asunto = "";
            Id = -1;
        }

        public ENSugerencias(string titulo, string texto,  int id) {
            Titulo = titulo;
            Texto = texto;
            
            Id = id;
        }


        public bool createSugerencia() {
            CADSugerencias s = new CADSugerencias();
                return s.createSugerencia(this);
        }

        public bool readSugerencia() {
            CADSugerencias s = new CADSugerencias();
                return s.readSugerencia(this);
        }

        public bool updateSugerencia() {
            CADSugerencias s = new CADSugerencias();
                return s.updateSugerencia(this);
        }

        public bool deleteSugerencia() {
            CADSugerencias s = new CADSugerencias();
                return s.deleteSugerencia(this);
        }
    }
}
