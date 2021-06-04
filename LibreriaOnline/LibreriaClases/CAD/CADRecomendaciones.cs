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
    /// <summary>
	/// Se utiliza para comprobar que las reomendaciones funcionen correctamente
	/// </summary>
    public class CADRecomendaciones
    {
        private String constring;
        public CADRecomendaciones()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }
        public bool Recomendado(ENRecomendaciones MiEnRecomendado)
        {
            if (!checkLibros(MiEnRecomendado.Genero))
            {
                return false;
            }

            try
            {
                //Nos conectamos a la BBDD
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Buscamos el libro con mayor nota para recomendarlo
                SqlCommand com = new SqlCommand("Select * from [dbo].[Libros] Where genero ='" + MiEnRecomendado.Genero + "'", c);
                SqlDataReader dr = com.ExecuteReader();
               
                if (dr.Read())
                {
                    //Igualamos los atributos de MiEnRecomendado a los sacados de la base de datos

                  
                }

                dr.Close();
                c.Close();
            }
            catch (SqlException e)
            {
                //Rodeamos el código con un try/catch para manejar las excepciones
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                return false;
            }

            return true;
        }

        public bool checkLibros(string l)
        {
            bool encontrado = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from [dbo].[Libros] Where genero='" + l + "'", c);
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