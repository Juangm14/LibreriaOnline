using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Almacena los libros que se ha leido el usuario con su puntuacion.
/// </summary>
public class ENListaUsuario
{
	private List<ENLibro> _libros;
	private int _puntuacion;

	public List<ENLibro> libros
	{
		get { return _libros; }
		set { _libros = value; }
	}
	public int puntuacion
    {
		get { return _puntuacion; }
		set { _puntuacion = value; }
    }

	public ENListaUsuario()
	{
		
	}


}
