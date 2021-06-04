using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaOnline {
	/// <summary>
	/// Se utiliza para comprobar que las reomendaciones funcionen correctamente
	/// </summary>
	public class ENRecomendaciones {
		string genero; //genero del libro para recomendar
		string usuario; //email del usuario, es decir su CP en la BBDD
		string critica; //también imprimimos la critica con la recomendación
		string titulo; //el título de la misma también se imprime
		bool correct; //Bool auxiliar para ver si el CAD ha funcionado bien

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
		public string Critica {
			get {
				return critica;
			}
			set {
				critica = value;
			}
		}
		public string Titulo {
			get {
				return titulo;
			}
			set {
				titulo = value;
			}
		}
		public string Genero {
			get {
				return genero;
			}
			set {
				genero = value; //Por si un usuario quiere cambiar su lista de recomendados por la de otro
			}
		}

		public bool Correct {
			get {
				return correct;
			}
			set {
				correct = value;
			}
		}
		public ENRecomendaciones() {
			genero = "";
			usuario = "";
			critica = "";
			titulo = "";
			correct = false;
		}

		public ENRecomendaciones(string gen, string usu, string cr, string ti, bool cor) {
			genero = gen;
			usuario = usu;
			critica = cr;
			titulo = ti;
			correct = cor;
		}

		public bool Recomendado() {
			CADRecomendaciones added = new CADRecomendaciones();
			//El CAD buscara el libro con mayor nota y lo devuelve guardandolo en los atributos ENRecomendaciones
			return added.Recomendado(this); ;
		}


	}

}