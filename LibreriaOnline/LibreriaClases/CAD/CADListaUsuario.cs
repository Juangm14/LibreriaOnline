using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CADListaUsuario
{
	private string costring;

	public CADListaUsuario()
	{
	}

	public bool addListaUsuario(ENListaUsuario en)
	{
		return true;
	}

	public bool removeListaUsuario(ENListaUsuario en)
	{
		return true;
	}

	public bool updatePuntuacion(ENListaUsuario eNListaUsuario)
	{
		return true;
	}

	public bool readPuntuacion(ENListaUsuario eNListaUsuario)
	{
		return true;
	}

    internal bool addPuntuacion(ENListaUsuario eNListaUsuario) {
        throw new NotImplementedException();
    }

    internal bool removePuntuacion(ENListaUsuario eNListaUsuario) {
        throw new NotImplementedException();
    }
}
