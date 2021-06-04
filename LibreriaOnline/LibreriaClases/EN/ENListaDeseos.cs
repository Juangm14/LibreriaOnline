using System;
using System.Collections.Generic;

namespace LibreriaOnline.EN {
	/// <summary>
	/// Guarda y borra los libros deseados por los usuarios
	/// </summary>
	public class ENListaDeseos {
		private int isbn; //los libros marcados como deseados
		private string usuario; //email del usuario, es decir su CP en la BBDD

		//Creamos todos los gets y sets correspondientes, por si acaso
		//Creamos los constructores correspondientes, por si acaso
		// *A la hora de la verdad en la prácticas muchos de estos no son utilizados, pero en un proyecto así siempre
		//viene bien tener esto creado para poder realizar una mantenimiento y pruebo de la aplicación bueno
		public string Usuario {
			get {
				return usuario;
			}
			set {
				usuario = value;
			}
		}

		public int Isbn {
			get {
				return isbn;
			}
			set {
				isbn = value;
			}
		}

		public ENListaDeseos() {
			isbn = 0;
			usuario = "";
		}
		public ENListaDeseos(int libro, string usu) {
			isbn = libro;
			usuario = usu;
		}

		public bool addDeseado(string aux) {
			CADListaDeseos added = new CADListaDeseos();
			return added.addDeseado(this, aux); //Return el bool del CAD, para ver si ha funcionado
		}

		public bool removeDeseado(string libro) {
			CADListaDeseos removed = new CADListaDeseos();
			int ISBN = removed.BuscaISBN(libro);

			if (checkLibros(ISBN)) //Comprobamos que este marcado como deseado
			{
				this.Isbn = ISBN;
				return removed.removeDeseado(this);
			}

			return false;
		}

		public bool checkLibros(int l) {
			if (this.isbn == l) {
				// Como internamente el método addDeseado a parte de insertar el libro en la BBDD también sobreescribe
				//el atributo string "deseados" si el último libro que has añadido lo quieres por ejemplo eliminar,
				//al tener guardado el valor podemos ahorranos que el checkLibros tenga que consultar la BBDD y así
				//ganar tiempo de respuesta de la aplicación
				return true;
			} else {
				CADListaDeseos exist = new CADListaDeseos();
				return exist.checkLibros(l);

			}
		}
	}
}