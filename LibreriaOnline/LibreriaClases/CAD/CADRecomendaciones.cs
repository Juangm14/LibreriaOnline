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
    public class CADRecomendaciones
    {
        private String constring;
        public CADRecomendaciones()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }
        public ENRecomendaciones addRecomendado(ENRecomendaciones MiEnRecomendado)
        {
            //Busca el libro con mejor puntuacion para recomendarlo a un usuario
            MiEnRecomendado.Correct = false;
            try
            {
                //Nos conectamos a la BBDD
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Buscamos el libro con mayor nota para recomendarlo
                SqlCommand com = new SqlCommand("Select * from [dbo].[Critica] MAX(nota)", c);
                SqlDataReader dr = com.ExecuteReader();
                //Igualamos los atributos de MiEnRecomendado a los sacados de la base de datos
                MiEnRecomendado.Recomendados = dr["ISBN"].ToString();
                MiEnRecomendado.Titulo = dr["titulo"].ToString();
                MiEnRecomendado.Critica = dr["critica"].ToString();
                MiEnRecomendado.Correct = true;
                dr.Close();
                c.Close();
            }
            catch (SqlException e)
            {
                //Rodeamos el código con un try/catch para manejar las excepciones
                MiEnRecomendado.Correct = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return MiEnRecomendado;
        }
        
    }
}
