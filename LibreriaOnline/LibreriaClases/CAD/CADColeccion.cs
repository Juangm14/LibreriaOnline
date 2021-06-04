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
				SqlCommand com1 = new SqlCommand("Insert into Coleccion (id,nombre) VALUES (" + en.id + ",'" + en.nombre + "')", c);
				SqlCommand com2 = new SqlCommand("Insert into ColeccionLibros (id,ISBN) VALUES (" + en.id + "," + en.coleccion + ")", c);
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
			bool deleted = true;
			SqlConnection c = new SqlConnection(constring);
			try
			{
				c.Open();
				SqlCommand com = new SqlCommand("Delete from Coleccion where id=" + en.id, c);
				if (com.ExecuteNonQuery() == 0)
					deleted = false;
			}
			catch (SqlException ex)
			{
				deleted = false;
				Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
			}
			finally { c.Close(); }
			
			return deleted;
		}

		public bool updateColeccion(ENColeccion en)
		{
			bool updated = true;
			SqlConnection c = new SqlConnection(constring);
			try
			{
				c.Open();
				SqlCommand com1 = new SqlCommand("Update ColeccionLibros set nombre='" + en.nombre + "' where id=" + en.id, c);
				SqlCommand com2 = new SqlCommand("Update Coleccion set nombre='" + en.nombre + "' where id=" + en.id, c);
				if (com1.ExecuteNonQuery() == 0 || com2.ExecuteNonQuery() == 0)
					updated = false;
			}
			catch (SqlException ex)
			{
				updated = false;
				Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
			}
			finally { c.Close(); }
			
			return updated;
		}

		public bool findLibros(ENColeccion en)
		{
			bool check = false;
			SqlConnection c = new SqlConnection(constring);
			try
			{
				c.Open();
				SqlCommand com = new SqlCommand("Select ISBN from Libros where titulo='" + en.nombre + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				check = dr.Read();
				en.coleccion = Int32.Parse(dr["ISBN"].ToString());
				dr.Close();
			}
			catch (SqlException ex)
			{
				check = false;
				Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
			}
			finally { c.Close(); }

			return check;
		}

		public bool getId(ENColeccion en)
		{
			bool get = false;
			SqlConnection c = new SqlConnection(constring);
			try
			{
				c.Open();
				SqlCommand com = new SqlCommand("Select id from Coleccion where nombre='" + en.nombre + "'", c);
				SqlDataReader dr = com.ExecuteReader();
				if (dr.Read())
				{
					en.id = int.Parse(dr["id"].ToString());
					get = true;
				}
				dr.Close();
			}
			catch (SqlException ex)
			{
				get = false;
				Console.WriteLine("Operation has failed.Error: {0}", ex.Message);
			}
			finally { c.Close(); }

			return get;
		}
	}
}

