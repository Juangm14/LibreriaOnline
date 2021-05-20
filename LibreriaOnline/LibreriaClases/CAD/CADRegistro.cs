using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LibreriaOnline.CAD
{
	public class CADRegistro
	{
		private String constring;
		public CADRegistro()
		{
			constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
		}

		public bool ExisteEmail(ENRegistro registro)
		{
			bool encontrado = false;
            try
            {
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Usuario] Where email='"+registro.Email+"'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
                {
					encontrado = true;
                }
				dr.Close();
				c.Close();
			}
			catch (SqlException e)
			{
				encontrado = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}

			return encontrado;
		}


		public bool ExisteNick(ENRegistro registro)
		{
			bool encontrado = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Usuario] Where nick='" + registro.Nick + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
				{
					encontrado = true;
				}
				dr.Close();
				c.Close();
			}
			catch (SqlException e)
			{
				encontrado = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}

			return encontrado;
		}

		public bool Registrar(ENRegistro registro)
		{
			bool creado = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Insert INTO Usuario (email, nick, contraseña, edad, telefono) VALUES ('" + registro.Email + "', '" + registro.Nick + "', '" + registro.Contrasena + "', "+registro.Edad+", "+registro.Telefono + ")", c);
				com.ExecuteNonQuery();
				creado = true;
				c.Close();
			}
			catch (SqlException e)
			{
				creado = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}
			return creado;
		}
		public bool ReadEmail(ENRegistro registro)
		{
			bool leido = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Usuario] Where email='" + registro.Email + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
				{
					registro.Contrasena = dr["contraseña"].ToString();
					leido = true;
				}
				dr.Close();
				c.Close();
			}
			catch (SqlException e)
			{
				leido = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}

			return leido;
		}

		public bool ReadNick(ENRegistro registro)
		{
			bool leido = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Usuario] Where nick='" + registro.Nick + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
				{
					registro.Contrasena = dr["contraseña"].ToString();
					leido = true;
				}
				dr.Close();
				c.Close();
			}
			catch (SqlException e)
			{
				leido = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}
			return leido;
		}

	}
}

