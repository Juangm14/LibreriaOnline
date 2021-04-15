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
		
	}

	
}
