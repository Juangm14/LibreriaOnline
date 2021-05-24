using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.CAD;

namespace LibreriaOnline.EN
{
	/// <summary>
	/// Almacena datos de una colección de libros
	/// </summary>
	public class ENColeccion
	{
		private int _id;
		private string _nombre;  //Nombre de la colección
		private int _coleccion; //Libro de la colección (ISBN)

		public int id
        {
			get { return _id; }
			set { _id = value; }
		}
		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public int coleccion
		{
			get { return _coleccion; }
			set { _coleccion = value; }
		}

		public ENColeccion()
		{
			_id = 1;
			_nombre = "";
			_coleccion = 0;
		}

		public ENColeccion(int id, string nom, int col)
		{
			_id = id;
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
	}
}

