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
        private string texto;

        public string getGenero() { return genero; }
        public void setGenero(string genero) { this.genero = genero; }
        public string getTitulo() { return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }
        public string getTexto() { return texto; }
        public void setTexto(string texto) { this.texto = texto; }

        public ENRelato(string titulo, string genero, string texto) {
            this.genero = genero;
            this.titulo = titulo;
            this.texto = texto;
        }

        public ENRelato() {
            this.genero = "";
            this.titulo = "";
            this.texto = "";
        }
        public bool createRelato() {
            CADRelato cad = new CADRelato();
            return cad.createRelato(this);
        }
        public bool deleteRelato() {
            CADRelato cad = new CADRelato();
            return cad.deleteRelato(this);
        }
        public bool updateRelato() {
            CADRelato cad = new CADRelato();
            return cad.updateRelato(this);
        }
        public bool bucarRelato() {
            CADRelato cad = new CADRelato();
            return cad.bucarRelato(this);
        }
    }
}