using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Almacena datos de una colección de libros
/// </summary>
public class ENColeccion
{
	private string _nombre;  //Nombre de la colección
	private List<ENLibro> _coleccion; //Libros de la colección

	public string nombre
    {
		get { return _nombre; }
		set { _nombre = value; }
    }

	public List<ENLibro> coleccion
    {
		get { return _coleccion; }
		set { _coleccion = value; }
    }

	public ENColeccion()
	{
		_nombre = "";
		_coleccion = new List<ENLibro>();
	}

	public ENColeccion(string nom, List<ENlibro> col)
    {
		_nombre = nom;
		_coleccion = col;
    }

	//Revisa si un libro en especifíco, se encuentra en la colección
	private bool checkLibro(ENLibro libro)
    {
		if (_coleccion.Contains(libro))
		{
			return true;
		}

		return false;
	}

	//Añade un libro a la colección
	public bool addColeccion(ENLibro libro)
    {
		CADColeccion c = new CADColeccion();

        if (!checkLibro(libro))
        {
			_coleccion.Add(libro);
			return c.addColeccion(this);
		}

		return false;
	}

	//Elimina un libro de la colección
	public bool removeColeccion(EnLibro libro)
    {
		CADColeccion c = new CADColeccion();

		if (checkLibro(libro))
        {
			_coleccion.Remove(libro);
			return c.removeColeccion(this);
		}
		
		return false;
	}


}
