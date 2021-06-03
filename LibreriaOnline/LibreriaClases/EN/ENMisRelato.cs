using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN {

    public class ENMisRelato {
        private string genero;
        private string titulo;
        private string texto;
        private string usuario;

        public string getGenero() { return genero; }
        public void setGenero(string genero) { this.genero = genero; }
        public string getTitulo() { return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }
        public string getTexto() { return texto; }
        public void setTexto(string texto) { this.texto = texto; }
        public string getUsuario() { return usuario; }
        public void setUsuario(string usuario) { this.usuario = usuario; }

        public ENMisRelato(string titulo, string genero, string texto) {
            this.genero = genero;
            this.titulo = titulo;
            this.texto = texto;
        }

        public ENMisRelato(string titulo, string genero, string texto, string usuario) {
            this.genero = genero;
            this.titulo = titulo;
            this.texto = texto;
            this.usuario = usuario;
        }

        public ENMisRelato() {
            this.genero = "";
            this.titulo = "";
            this.texto = "";
        }
        public bool createRelato() {
            CADMisRelato cad = new CADMisRelato();
            return cad.createRelato(this);
        }
        public bool deleteRelato() {
            CADMisRelato cad = new CADMisRelato();
            return cad.deleteRelato(this);
        }
        public bool updateRelato() {
            CADMisRelato cad = new CADMisRelato();
            return cad.updateRelato(this);
        }
        public bool bucarRelato() {
            CADMisRelato cad = new CADMisRelato();
            return cad.bucarRelato(this);
        }
    }
}