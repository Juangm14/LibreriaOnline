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
		private string _usuario;
		private string _libro;
		private int _puntuacion;

		public string usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}
		public string libro
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
			_usuario = "";
			_libro = "";
			_puntuacion = 0;
		}

		public ENListaUsuario(string usu, string li, int p)
		{
			_usuario = usu;
			_libro = li;
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

		public bool updatePuntuacion()
        {
			CADListaUsuario c = new CADListaUsuario();

			return c.updatePuntuacion(this);
		}

		public bool readPuntuacion()
        {
			CADListaUsuario c = new CADListaUsuario();

			return c.readPuntuacion(this);
		}
	}
}

