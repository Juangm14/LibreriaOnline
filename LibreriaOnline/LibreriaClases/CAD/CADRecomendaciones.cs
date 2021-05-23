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
        public bool addRecomendado(ENRecomendaciones lista)
        {
            //Actualiza la lista de recomendados de un usuario, al añadir un libro
            bool encontrado = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from [dbo].[Critica] MAX(nota)", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    lista.Recomendados = dr["ISBN"].ToString();
                    lista.Titulo = dr["titulo"].ToString();
                    lista.Critica = dr["critica"].ToString();

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
        
    }
}
