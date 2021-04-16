using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    public class ENlibros
    {
        private string ISBN;
        private string Autores;
        private string Titulo;
        private string Editorial;
        private string Genero;


        public string ISBN()
        {
            get { ISBN; }
            set { ISBN = value; }
        }

        public string Autores()
        {
            get { Autores; }
            set { Autores = value; }
        }

        public string Titulo()
        {
            get { Titulo}
            set { Titulo = value; }
        }

        public string Editorial()
        {
            get { Editorial; }
            set { Editorial = value; }
        }

        public string Genero()
        {
            get { Genero; }
            set { Genero = value; }
        }

        public ENlibros()
        {
            ISBN = "";
            Autores = "";
            Titulo = "";
            Editorial = "";
            Genero = "";
        }

        public ENlibros(string isbn, string autores, string titulo, string editorial, string genero)
        {
            ISBN = isbn;
            Autores = autores;
            Titulo = titulo;
            Editorial = editorial;
            Genero = genero;
        }

        public bool createLibros()
        {
            CADlibros cl = new CADlibros();
            return c1.addLibro(this);
        }

        public bool deleteLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.deleteLibros(this);
        }

        public bool updateLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.updateLibros(this);
        }

        public bool adminLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.adminLibros(this);
        }
        public bool ColeccionLibros(this)
        {
            CADlibros c1 = new CADlibros();
            return c1.ColeccionLibros(this);
        }

        public bool CriticaLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.CriticaLibros(this);
        }

        public bool CompraLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.CompraLibros(this);
        }

        public bool NotaLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.NotaLibros(this);
        }

        public bool updateLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.updateLibros(this);
        }

        public bool RecomiendaLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.RecomiendaLibros(this);
        }

        public bool relUsuarioLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.relUsuarioLibros(this);
        }
    }
}
