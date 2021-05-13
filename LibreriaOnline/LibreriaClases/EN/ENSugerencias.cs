using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    class ENSugerencias {
        private string titulo;
        private string texto;
        private int id;
        private string autor;


        public string titulo_ {
            get { return titulo; }
            set { titulo = value; }
        }

        public string texto_ {
            get { return texto; }
            set { texto = value; }
        }

        public int id_ {
            get { return id; }
            set { id = value; }
        }

        public string autor_ {
            get { return autor; }
            set { autor = value; }
        }

        public ENSugerencias() {
            this.titulo = "";
            texto = "";
            autor = "";
            id = 0;
        }

        public ENSugerencias(string titulo, string texto, string autor, int id) {
            this.titulo = titulo;
            this.texto = texto;
            this.autor = autor;
            this.id = id;
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
