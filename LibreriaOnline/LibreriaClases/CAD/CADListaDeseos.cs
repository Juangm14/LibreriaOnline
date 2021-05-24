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

        //Los tres métodos de esta clase funcionan de manera muy similar...
        public bool addDeseado(ENListaDeseos param)
        {
            bool anyadido = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open(); //... Primero se conectan con la BBDD
                SqlCommand com = new SqlCommand("Insert INTO ListaDeseo (email, ISBN) VALUES ('" + param.Usuario + "', '" + param.Deseados + ")", c);
                com.ExecuteNonQuery(); //Y ejecutan cada uno su respectivo comando
                anyadido = true; //Si todo sale bien se devuelve true y no se ha lanzado ninguna excepción
                c.Close();
            }
            catch (SqlException e)
            {
                //Los tres estan rodeados de try/catch para capturar las posibles excepciones que se produzcan
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

        public bool checkLibros(string l)
        {
            bool encontrado = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from [dbo].[ListaDeseo] Where ISBN='" + l + "'", c);
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
                Console.WriteLine("Error: {0}", e.Message, " El libro no se encuntra marcado como deseado");
            }

            return encontrado;
        }
    }
}
