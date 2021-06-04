using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaOnline {
    public class ENlibros
    {
        private int ISBN;
        public void setISBN(int isbn)
        {
            ISBN = isbn;
        }
        public int getISBN()
        {
            return ISBN;
        }

        private string Autores;
        public void setAutores(string autores)
        {
            Autores = autores;
        }
        public string getAutores()
        {
            return Autores;
        }

        private string Titulo;
        public void setTitulo(string titulo)
        {
            Titulo = titulo;
        }
        public string getTitulo()
        {
            return Titulo;
        }
        private string Editorial;

        public void setEditorial(string editorial)
        {
            Editorial = editorial;
        }
        public string getEditorial()
        {
            return Editorial;
        }
        private string Genero;
        public void setGenero(string genero)
        {
            Genero = genero;
        }
        public string getGenero()
        {
            return Genero;
        }
        private string Proveedor;
        public void setProveedor(string proveedor)
        {
            Proveedor = proveedor;
        }
        public string getProveedor()
        {
            return Proveedor;
        }
        private float Precio;
        public float getPrecio()
        {
            return Precio;
        }
        public void setPrecio(float precio)
        {
            Precio = precio;
        }
        private string Imagen;
        public void setImagen(string imagen)
        {
            Imagen = imagen;
        }
        public string getImagen()
        {
            return Imagen;
        }


        public ENlibros(string isbn, string proveedor)
        {
            ISBN = 30;
            Autores = "";
            Titulo = "";
            Editorial = "";
            Genero = "";
            Proveedor = proveedor;
            Precio = 0;
            Imagen = "";
        }

        public ENlibros(string isbn, string autores, string titulo, string editorial, string genero, string proveedor, float precio, string imagen)
        {
            ISBN = int.Parse(isbn);
            Autores = autores;
            Titulo = titulo;
            Editorial = editorial;
            Genero = genero;
            Proveedor = proveedor;
            Precio = precio;
            Imagen = imagen;
        }

        public bool CreateLibros()
        {
            CADlibros cl = new CADlibros();
            return cl.CreateLibros(this);
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

        public bool buscarLibro()
        {
            CADlibros cad = new CADlibros();
            return cad.buscarLibro(this);
        }

        public bool adminLibros()
        {
            CADlibros c1 = new CADlibros();
            return c1.adminLibros(this);
        }
        public bool ColeccionLibros() 
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
