using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace LibreriaOnline
{
    public class CADListaDeseos
    {
        private String constring;
        public CADListaDeseos()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }
        public bool addDeseado(ENListaDeseos param)
        {
            bool anyadido = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Insert INTO ListaDeseo (email, ISBN) VALUES ('" + param.Usuario + "', '" + param.Deseados + ")", c);
                com.ExecuteNonQuery();
                anyadido = true;
                c.Close();
            }
            catch (SqlException e)
            {
                anyadido = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return anyadido;
        }

        public bool removeDeseado(ENListaDeseos param)
        {
            bool eliminado = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Delete from [dbo].[ListaDeseo] Where ISBN='" + param.Deseados + "'", c);
                com.ExecuteNonQuery();
                eliminado = true;
                c.Close();
            }
            catch (SqlException e)
            {
                eliminado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return eliminado;
        }
    }
}

