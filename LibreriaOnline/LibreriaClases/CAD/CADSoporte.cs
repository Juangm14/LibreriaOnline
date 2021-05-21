using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
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

			public bool readPregunta(ENSoporte soporte)
			{
				return true;
			}
			public bool readFirstPregunta(ENSoporte soporte)
			{
				return true;
			}

			public bool createPregunta(ENSoporte soporte)
			{
				bool creado = false;
			try
			{
				SqlConnection c = new SqlConnection(constring);
				c.Open();
				SqlCommand com = new SqlCommand("Insert INTO Usuario (pregunta, asunto) VALUES ('" + soporte.Pregunta +"' '"+soporte.Asunto+"'", c);
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

			public bool readFirtPregunta(ENSoporte soporte)
			{
				return true;
			}
			public bool readNextPregunta(ENSoporte soporte)
			{
				return true;
			}
			public bool readPrevPregunta(ENSoporte soporte)
			{
				return true;

			}
			public bool editPregunta(ENSoporte soporte)
			{
				return true;
			}
			public bool deletePregunta(ENSoporte soporte)
			{
				return true;
			}
		}
	}


