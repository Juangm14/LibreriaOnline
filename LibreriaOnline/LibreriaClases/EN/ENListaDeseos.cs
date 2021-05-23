using System;
using System.Collections.Generic;

namespace LibreriaOnline.EN
{
	public class ENListaDeseos
	{
		string deseados; //lista con los libros marcados como deseados
		string usuario; //email del usuario, es decir su CP en la BBDD

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

		public string Deseados
		{
			get
			{
				return deseados;
			}
			set
			{
				deseados = value; //Por si un usuario quiere cambiar su lista de deseos por la de otro
			}
		}

		public ENListaDeseos()
		{
			deseados = "" ;
			usuario = "";
		}
		public ENListaDeseos(string libro, string usu)
		{
			deseados = libro;
			usuario = usu;
		}

		public bool addDeseado(string libro)
        {
			CADListaDeseos added = new CADListaDeseos();

            if (!checkLibros(libro)) //No esta ya marcado como deseado
            {
				this.deseados = libro;
				return added.addDeseado(this);
			}

			return false;
        }

		public bool removeDeseado(string libro)
		{
			CADListaDeseos removed = new CADListaDeseos();

			if (checkLibros(libro))
            {
				return removed.removeDeseado(this);
			}

			return false;
		}

		private bool checkLibros(string l)
        {
			if (this.deseados.Contains(l))
			{
				return true;
			}

			return false;
        }
	}
}

