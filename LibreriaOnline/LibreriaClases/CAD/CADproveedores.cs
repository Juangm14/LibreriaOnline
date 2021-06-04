using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.CAD
{
	public class CADProveedores
	{
		private String cadenaConexion;
		public CADProveedores()
		{
			cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
		}

		public bool ExisteEmail(ENProveedores en)
		{
			bool encontrado = false;
			try
			{
				SqlConnection c = new SqlConnection(cadenaConexion);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Proveedor] Where email='" + en.getEmail() + "'", c);
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

		public bool CrearProveedor(ENProveedores en)
		{
			bool creado = false;
			try
			{
				SqlConnection c = new SqlConnection(cadenaConexion);
				c.Open();
				SqlCommand com = new SqlCommand("Insert INTO Proveedor (Email, Nombre, Contraseña, Telefono, TipoLibro ) VALUES ('" + en.getEmail() + "', '" + en.getNombre() + "', '" + en.getContraseña() + "','" + en.getTelefono() + "', '" + en.getTipoLibro() + "')", c);
				int filasAfectadas= com.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
					creado = true;
				}		
				c.Close();
			}
			catch (SqlException e)
			{
				creado = false;
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}
			return creado;
		}
		public bool ReadEmail(ENProveedores en)
		{
			bool leido = false;
			try
			{
				SqlConnection c = new SqlConnection(cadenaConexion);
				c.Open();
				SqlCommand com = new SqlCommand("Select * from [dbo].[Proveedor] Where email='" + en.getEmail() + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
				{
					en.setContraseña(dr["contraseña"].ToString());
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

		public bool Registrar(ENProveedores en)
		{
			bool creado = false;
			try
			{
				SqlConnection c = new SqlConnection(cadenaConexion);
				c.Open();
				SqlCommand com = new SqlCommand("Insert INTO Proveedor (Email, Nombre, Telefono, TipoLibro, Contraseña) VALUES ('" + en.getEmail() + "', '" + en.getNombre() + "', '" + en.getTelefono() + "', " + en.getTipoLibro() + ", " + en.getContraseña() + ")", c);
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

	}
}
