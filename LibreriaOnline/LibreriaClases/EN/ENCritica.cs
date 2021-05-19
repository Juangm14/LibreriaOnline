using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN {
    public class ENCritica {
        private string texto;
        private string titulo;
        private int nota;

        public string getTexto() {
            return texto;
        }

        public void settexto(string texto) {
            this.texto = texto;
        }
        public string getTitulo() {
            return titulo;
        }

        public void setTitulo(string titulo) {
            this.titulo = titulo;
        }
        public int getNota() {
            return nota;
        }

        public void setNota(int nota) {
            this.nota = nota;
        }
        public ENCritica() {
            texto = "";
            titulo = "";
            nota = 0;
        }

        public ENCritica(string texto, string titulo, string nota) {
            this.nota = int.Parse(nota);
            this.texto = texto;
            this.titulo = titulo;
        }

        public bool createCritica() {
            CADCritica cad = new CADCritica();
            return cad.createCritica(this);
        }
        public bool deleteCritica() {
            CADCritica cad = new CADCritica();
            return cad.deleteCritica(this);
        }
        public bool updateCritica() {
            CADCritica cad = new CADCritica();
            return cad.updateCritica(this);
        }
        public bool buscarCritica() {
            CADCritica cad = new CADCritica();
            return cad.buscarCritica(this);
        }
    }
}
