using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.CAD;

namespace LibreriaOnline.EN
{
	/// <summary>
	/// Almacena los libros que se ha leido el usuario con su puntuacion.
	/// </summary>
	public class ENListaUsuario
	{
		private string _usuario;
		private int _libro;
		private int _nota;

		public string usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}
		public int libro
		{
			get { return _libro; }
			set { _libro = value; }
		}
		public int nota
		{
			get { return _nota; }
			set { _nota = value; }
		}

		public ENListaUsuario()
		{
			_usuario = "";
			_libro = 0;
			_nota = 0;
		}

		public ENListaUsuario(string usu, int li, int p)
		{
			_usuario = usu;
			_libro = li;
			_nota = p;
		}

		//Añade la puntuación a la BBDD, con su respectivo usuario y libro
		public bool addListaUsuario()
		{
			CADListaUsuario c = new CADListaUsuario();

			return c.addListaUsuario(this);
		}

		//Elimina la puntuación de la BBDD
		public bool removeListaUsuario()
		{
			CADListaUsuario c = new CADListaUsuario();

			return c.removeListaUsuario(this);
		}

		public bool updateListaUsuario()
        {
			CADListaUsuario c = new CADListaUsuario();

			return c.updateListaUsuario(this);
		}
	}
}

