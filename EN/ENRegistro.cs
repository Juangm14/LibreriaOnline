using System;

public class ENResgistro
{
	string email;
	string nombre;
	string apellidos;
	int telefono;
	string nick;
	int edad;
	string direccion;
	string contrasena;

	public string Contrasena
	{
		get { contrasena}
		set { contrasena = value}
	}

	public string Email
    {
		get { email}
        set { email=value}
    }
	public string Nombre
	{
		get { nombre}
		set { nombre = value}
	}
	public string Apellidos
	{
		get { apellidos}
		set { apellidos = value}
	}
	public string Direccion
	{
		get { direccion}
		set { direccion = value}
	}
	public string Nick
	{
		get { nick}
		set { nick = value}
	}
	public int Edad
	{
		get { edad}
		set { edad = value}
	}
	public int Telefono
	{
		get { telefono}
		set { telefono = value}
	}

	public ENRegistro()
	{
		 Email="";
		Nombre = "";
		Apellidos = "";
		 Telefono =0;
		 Nick = "";
		 Edad =0;
		 Direccion = "";
		Contrasena = "";
	}
	public ENRegistro(string email, string nombre, string apellidos, int telefono, string nick, int edad, string direccion, string contrasena)
    {
		Email = email;
		Nombre = nombre;
		Apellidos = apellidos;
		Telefono = telefono;
		Nick = nick;
		Edad = edad;
		Direccion = direccion;
		Contrasena = contrasena;
	}

	public bool Registrar()
    {
		CADRegistro registro = new CADRegistro();
        if (!(registro.ExisteEmail(this) || registro.ExisteNick(this)))
        {
			return registro.Registrar(this);
        }
        else
        {
			return false;
        }
    }
	public bool EmailRepetido()
    {
		CADRegistro registro = new CADRegistro();
		return registro.ExisteEmail(this);
	}
	public bool NickRepetido()
	{
		CADRegistro registro = new CADRegistro();
		return registro.ExisteNick(this);
	}

	public bool Log()
    {
		ENRegistro verificar = new ENRegistro();
		CADRegistro registro = new CADRegistro();
        if (registro.ExisteEmail(this))
        {
			verificar.Email = Email;
			registro.ReadEmail(verificar);
            if (verificar.Contrasena == Contrasena)
            {
				return true;
            }
            else
            {
				return false;
            }
        }
		else if (registro.ExisteNick(this))
        {
			verificar.Nick = Nick;
			registro.ReadNick(verificar);
            if (verificar.Contrasena == Contrasena)
            {
				return true;
            }
            else
            {
				return false;
            }
		}
        else
        {
			return false;
        }

	}
}
