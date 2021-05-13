using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaOnline
{
	public class ENRecomendaciones
	{
		private List<ENlibros> recomendados;
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

		public List<ENlibros> Recomendados
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
			recomendados =  new List<ENlibros>();
			usuario = "";
		}

		public ENRecomendaciones(List<ENlibros> reco, string usu)
		{
			recomendados = reco;
			usuario = usu;
		}

		public bool addRecomendado(ENlibros libro)
		{
			CADRecomendaciones added = new CADRecomendaciones();

			if (!checkLibros(libro)) //No esta ya marcado como recomendado
			{
				this.recomendados.Add(libro);
				return added.addRecomendado(this);
			}

			return false;
		}

		public bool removeDeseado(ENlibros libro)
		{
			CADRecomendaciones removed = new CADRecomendaciones();

			if (checkLibros(libro))
			{
				this.recomendados.Remove(libro);
				return removed.removeRecomendado(this);
			}

			return false;
		}

		private bool checkLibros(ENlibros l)
		{
			if (this.recomendados.Contains(l))
			{
				return true;
			}

			return false;
		}

	}

}
