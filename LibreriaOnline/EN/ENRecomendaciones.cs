using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class ENRecomendaciones
	{
		private List<ENLibro> recomendados;
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

		public List<ENLibro> Recomendados
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
			recomendados =  new List<ENULibro>();
			usuario = "";
		}

		public ENRecomendaciones(List<ENULibro> reco, string usu)
		{
			recomendados = reco;
			usuario = usu;
		}

		public bool addRecomendado(ENULibro libro)
		{
			CADRecomendaciones added = new CADRecomendaciones();

			if (!checkLibros(libro)) //No esta ya marcado como recomendado
			{
				this.recomendados.Add(libro);
				return added.addRecomendado(this);
			}

			return false;
		}

		public bool removeDeseado(ENULibro libro)
		{
			CADRecomendaciones removed = new CADRecomendaciones();

			if (checkLibros(libro))
			{
				this.recomendados.Remove(libro);
				return removed.removeRecomendado(this);
			}

			return false;
		}

		private bool checkLibros(ENULibro l)
		{
			if (this.recomendados.Contains(l))
			{
				return true;
			}

			return false;
		}

	}

}
