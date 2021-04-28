using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	/// Almacena datos de una colección de libros
	/// </summary>
	public class ENColeccion
	{
		private string _nombre;  //Nombre de la colección
		private string _coleccion; //Libro de la colección

		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public string coleccion
		{
			get { return _coleccion; }
			set { _coleccion = value; }
		}

		public ENColeccion()
		{
			_nombre = "";
			_coleccion = "";
		}

		public ENColeccion(string nom, string col)
		{
			_nombre = nom;
			_coleccion = col;
		}


		//Añade un libro a la colección
		public bool addColeccion()
		{
			CADColeccion c = new CADColeccion();

			return c.addColeccion(this);
		}

		//Elimina un libro de la colección
		public bool removeColeccion()
		{
			CADColeccion c = new CADColeccion();

			return c.removeColeccion(this);
		}

		public bool updateColeccion()
		{
			CADColeccion c = new CADColeccion();

			return c.updateColeccion(this);
		}

		public bool readColeccion()
        {
			CADColeccion c = new CADColeccion();

			return c.readColeccion(this);
		}
	}
}

