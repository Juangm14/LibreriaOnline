using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN {
	public class ENRegistro //Clase que sirve para registrar un nuevo usuario en la pantalla de registro y para iniciar sesión en la pantalla de inicio de sesión
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
			get { return contrasena; }
			set { contrasena = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value;}
		}
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Apellidos
		{
			get { return apellidos; }
			set { apellidos = value; }
		}
		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}
		public string Nick
		{
			get { return nick; }
			set { nick = value; }
		}
		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		public ENRegistro()
		{
			Email = "";
			Nombre = "";
			Apellidos = "";
			Telefono = 0;
			Nick = "";
			Edad = 0;
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

		public bool Registrar() //Registra el usuario
		{
			CADRegistro registro = new CADRegistro();
			if (!(registro.ExisteEmail(this) || registro.ExisteNick(this))) //Si existe ya una cuenta con el mismo nick o email, devolvera false y no se creara
			{
				return registro.Registrar(this);
			}
			else
			{
				return false;
			}
		}
		public bool EmailRepetido() //Comprueba si existe ya una cuenta con ese email
		{
			CADRegistro registro = new CADRegistro();
			return registro.ExisteEmail(this);
		}
		public bool NickRepetido() //Comprueba si existe ya una cuenta con ese nick
		{
			CADRegistro registro = new CADRegistro();
			return registro.ExisteNick(this);
		}

		public bool Log() //Funcion para comprobar que un inicio de sesion es valido
		{
			ENRegistro verificar = new ENRegistro();
			CADRegistro registro = new CADRegistro();
			if (registro.ExisteEmail(this)) //Como se puede iniciar sesion tanto poniendo el nick como el email, primero comprueba si existe el emailc on el que se esta intentando iniciar sesión.
			{
				verificar.Email = Email; 
				registro.ReadEmail(verificar);
				if (verificar.Contrasena == Contrasena) //Si existe un usuario con ese email en la base de datos, comprueba que la contraseña introducida coincida con la que hay en la base de datos.
				{
					return true; // Si coincide, devuelve true.
				}
				else
				{
					return false; //Si no, devuelve false.
				}
			}
			else if (registro.ExisteNick(this)) //Si no existe un correo con ese nombre, comprueba si hay algun nick con ese nombre.
			{
				verificar.Nick = Nick;
				registro.ReadNick(verificar);
				if (verificar.Contrasena == Contrasena) //Si existe un usuario con ese nick en la base de datos, comprueba que la contraseña introducida coincida con la que hay en la base de datos.
				{
					return true; // Si coincide, devuelve true.
				}
				else
				{
					return false; //Si no, devuelve false.
				}
			}
			else
			{
				return false; // Si ni el nick ni el correo existen, devuelve false.
			}

		}
	}
}
