using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using LibreriaOnline.EN;

namespace LibreriaOnline.CAD
{
	public class CADColeccion
	{
		private string constring;

		public CADColeccion()
		{
			constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
		}

		public bool addColeccion(ENColeccion en)
		{
			bool added = true;
			SqlConnection c = new SqlConnection(constring);
			try
			{
				c.Open();
				SqlCommand com1 = new SqlCommand("Insert into Coleccion (id,nombre) VALUES ('" + en.id + "','" + en.nombre + "')", c);
				SqlCommand com2 = new SqlCommand("Insert into ColeccionLibros (id,ISBN) VALUES ('" + en.id + "','" + en.coleccion + "')", c);
				if (com1.ExecuteNonQuery() == 0 || com2.ExecuteNonQuery() == 0)
					added = false;
			}
			catch (SqlException ex)
			{
				added = false;
				Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
			}
			finally { c.Close(); }
			
			return added;
		}

		public bool removeColeccion(ENColeccion en)
		{
			return true;
		}

		public bool updateColeccion(ENColeccion eNColeccion)
		{
			return true;
		}

		public bool readColeccion(ENColeccion eNColeccion)
		{
			return true;
		}
	}
}

