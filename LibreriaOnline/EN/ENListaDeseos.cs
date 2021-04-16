using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class ENListaDeseos
	{
		List<ENLibro> deseados; //lista con los libros marcados como deseados
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

		public List<ENLibro> Deseados
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
			deseados = new List<ENULibro>(); ;
			usuario = "";
		}
		public ENListaDeseos(ENULibro libro, string usu)
		{
			deseados.Add(libro);
			usuario = usu;
		}

		public bool addDeseado(ENULibro libro)
        {
			CADListaDeseos added = new CADListaDeseos();

            if (!checkLibros(libro)) //No esta ya marcado como deseado
            {
				this.deseados.Add(libro);
				return added.addDeseado(this);
			}

			return false;
        }

		public bool removeDeseado(ENULibro libro)
		{
			CADListaDeseos removed = new CADListaDeseos();

			if (checkLibros(libro))
            {
				this.deseados.Remove(libro);
				return removed.removeDeseado(this);
			}

			return false;
		}

		private bool checkLibros(ENULibro l)
        {
			if (this.deseados.Contains(l))
			{
				return true;
			}

			return false;
        }
	}
}

