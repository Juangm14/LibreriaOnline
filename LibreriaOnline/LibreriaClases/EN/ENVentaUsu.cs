using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace LibreriaOnline
{
    public class ENVentaUsu
    {
        int id;
        float precio;
        string usuario;
        int libro;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }
        public int Libro
        {
            get
            {
                return libro;
            }
            set
            {
                libro = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public ENVentaUsu()
        {
            id = 0;
            precio = 0;
            usuario = "";
            libro =0;
        }

        public bool Leer() //Lee una oferta
        {
            CADVentaUsu exist = new CADVentaUsu();
            return exist.Leer(this);
        }

        public bool Insertar() //Crea una nueva oferta
        {
            CADVentaUsu exist = new CADVentaUsu();
            return exist.Insertar(this);
        }

        public bool Borrar() //Borra una oferta 
        {
            CADVentaUsu exist = new CADVentaUsu();
            return exist.Borrar(this);
        }

        public DataSet Lista() //Devuelve un dataset de las ofertas para nuestro grid.
        {
            CADVentaUsu cad = new CADVentaUsu();
            return cad.Lista();
        }
    }
}