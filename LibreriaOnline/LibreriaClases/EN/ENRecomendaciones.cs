using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaOnline
{
	public class ENRecomendaciones
	{
		string recomendados; //libro para recomendar
		string usuario; //email del usuario, es decir su CP en la BBDD
        string critica;
		string titulo;

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
		public ENRecomendaciones()
		{
			recomendados =  "";
			usuario = "";
		}

		public ENRecomendaciones(string reco, string usu)
		{
			recomendados = reco;
			usuario = usu;
		}

		public bool addRecomendado(string libro)
		{
			CADRecomendaciones added = new CADRecomendaciones();

			if (!checkLibros(libro)) //No esta ya marcado como recomendado
			{
				this.recomendados = libro;
				return added.addRecomendado(this);
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
