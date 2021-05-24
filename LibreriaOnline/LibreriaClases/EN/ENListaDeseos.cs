using System;
using System.Collections.Generic;

namespace LibreriaOnline.EN
{
	public class ENListaDeseos
	{
		private string deseados; //los libros marcados como deseados
		private string usuario; //email del usuario, es decir su CP en la BBDD

		//Creamos todos los gets y sets correspondientes, por si acaso
		//Creamos los constructores correspondientes, por si acaso
		// *A la hora de la verdad en la prácticas muchos de estos no son utilizados, pero en un proyecto así siempre
		//viene bien tener esto creado para poder realizar una mantenimiento y pruebo de la aplicación bueno
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
				deseados = value;
			}
		}

		public ENListaDeseos()
		{
			deseados = "";
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
				return added.addDeseado(this); //Return el bool del CAD, para ver si ha funcionado
			}

			return false; //Si esta marcado como deseado se devuelve false
		}

		public bool removeDeseado(string libro)
		{
			CADListaDeseos removed = new CADListaDeseos();

			if (checkLibros(libro)) //Comprobamos que este marcado como deseado
			{
				return removed.removeDeseado(this);
			}

			return false;
		}

		public bool checkLibros(string l)
		{
			if (this.deseados == l)
			{
				// Como internamente el método addDeseado a parte de insertar el libro en la BBDD también sobreescribe
				//el atributo string "deseados" si el último libro que has añadido lo quieres por ejemplo eliminar,
				//al tener guardado el valor podemos ahorranos que el checkLibros tenga que consultar la BBDD y así
				//ganar tiempo de respuesta de la aplicación
				return true;
			}
			else
			{
				CADListaDeseos exist = new CADListaDeseos();
				return exist.checkLibros(l);

			}
		}
	}
}