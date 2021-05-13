using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN {

        public class ENRelato {
            private string genero;
            private string titulo;

            public string getTexto() {
                return genero;
            }

            public string getTitulo() {
                return titulo;
            }
            public void setTexto(string genero) {
                this.genero = genero;
            }

            public void setTitulo(string titulo) {
                this.titulo = titulo;
            }
            public bool createRelato() {
                CADRelato cad = new CADRelato();
                return cad.createRelato(this);
            }
            public bool deleteCritica() {
                CADRelato cad = new CADRelato();
                return cad.deleteRelato(this);
            }
            public bool updateCritica() {
                CADRelato cad = new CADRelato();
                return cad.updateRelato(this);
            }
            public bool leerCritica() {
                CADRelato cad = new CADRelato();
                return cad.leerRelato(this);
            }
        }
    }