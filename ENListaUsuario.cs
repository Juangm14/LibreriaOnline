using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	/// Almacena los libros que se ha leido el usuario con su puntuacion.
	/// </summary>
	public class ENListaUsuario
	{
		private ENUsuario _usu;
		private ENLibro _libro;
		private int _puntuacion;

		public ENUsuario usu
		{
			get { return _usu; }
			set { _usu = value; }
		}
		public ENLibro libro
		{
			get { return _libro; }
			set { _libro = value; }
		}
		public int puntuacion
		{
			get { return _puntuacion; }
			set { _puntuacion = value; }
		}

		public ENListaUsuario()
		{
			_usu = new ENUsuario();
			_libro = new ENLibro();
			_puntuacion = 0;
		}

		public ENListaUsuario(ENUsuario u, ENlibro l, int p)
		{
			_usu = u;
			_libro = l;
			_puntuacion = p;
		}

		//Añade la puntuación a la BBDD, con su respectivo usuario y libro
		public bool addPuntuacion()
		{
			CADListaUsuario c = new CADListaUsuario();

			return c.addPuntuacion(this);
		}

		//Elimina la puntuación de la BBDD
		public bool removePuntuacion()
		{
			CADListaUsuario c = new CADListaUsuario();

			return c.removePuntuacion(this);
		}
	}
}

