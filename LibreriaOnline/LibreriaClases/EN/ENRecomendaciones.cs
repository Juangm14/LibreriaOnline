using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaOnline
{
	public class ENRecomendaciones
	{
		string recomendados; //libro para recomendar
		string usuario; //email del usuario, es decir su CP en la BBDD
		string critica; //también imprimimos la critica con la recomendación
		string titulo; //el título de la misma también se imprime
		bool correct; //Bool auxiliar para ver si el CAD ha funcionado bien

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
		public string Critica
		{
			get
			{
				return critica;
			}
			set
			{
				critica = value;
			}
		}
		public string Titulo
		{
			get
			{
				return titulo;
			}
			set
			{
				titulo = value;
			}
		}
		public string Recomendados
		{
			get
			{
				return recomendados;
			}
			set
			{
				recomendados = value; //Por si un usuario quiere cambiar su lista de recomendados por la de otro
			}
		}

		public bool Correct
		{
			get
			{
				return correct;
			}
			set
			{
				correct = value;
			}
		}
		public ENRecomendaciones()
		{
			recomendados = "";
			usuario = "";
			critica = "";
			titulo = "";
			correct = false;
		}

		public ENRecomendaciones(string reco, string usu, string cr, string ti, bool cor)
		{
			recomendados = reco;
			usuario = usu;
			critica = cr;
			titulo = ti;
			correct = cor;
		}

		public bool addRecomendado(string libro)
		{
			CADRecomendaciones added = new CADRecomendaciones();

			if (!checkLibros(libro)) //No esta ya marcado como recomendado
			{
				this.recomendados = libro;
				//El CAD buscara el libro con mayor nota y lo devuelve guardandolo en los atributos ENRecomendaciones
				ENRecomendaciones aux = added.addRecomendado(this);

				return aux.correct;

			}

			return false;
		}

		private bool checkLibros(string l)
		{
			if (this.recomendados.Contains(l))
			{
				return true;
			}

			return false;
		}

	}

}