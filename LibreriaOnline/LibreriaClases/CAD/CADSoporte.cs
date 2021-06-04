using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.CAD
{
	public class CADSoporte
	{
		private String constring;

			public CADSoporte()
			{
			constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
			}

			public bool readPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
			{
				return true;
			}
			public bool readFirstPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
			{
				return true;
			}
			public DataSet Lista() //Devuelve un DataSet compuesto de todas las preguntas contestadas por los administradores de la pagina
			{
			DataSet bdvirtual = new DataSet();
			try
			{
				SqlConnection c = new SqlConnection(constring);
				SqlDataAdapter da = new SqlDataAdapter("SELECT pregunta AS Pregunta, respuesta AS Respuesta from Soporte where respuesta is NOT NULL", c);

				da.Fill(bdvirtual, "Preguntas Frecuentes");
			}
			catch (SqlException e)
			{
				Console.WriteLine("User operation has failed.Error: {0}", e.Message);
			}
			return bdvirtual;
			}
			public bool createPregunta(ENSoporte soporte) //Crea una pregunta
			{
				bool creado = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Insert INTO Soporte (pregunta, asunto) VALUES ('" + soporte.Pregunta +"', '"+soporte.Asunto+"')", c);
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
		 
			public bool readFirtPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
		{
				return true;
			}
			public bool readNextPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
		{
				return true;
			}
			public bool readPrevPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
		{
				return true;

			}
			public bool editPregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
		{
				return true;
			}
			public bool deletePregunta(ENSoporte soporte) //Metodo no necesario para nuestro programa
		{
				return true;
			}
		}
	}


