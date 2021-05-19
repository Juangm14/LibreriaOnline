using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.CAD {
    class CADCritica {
        string conexionCritica;
        public CADCritica() {
            conexionCritica = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" +
                  "C:\\Users\\Usuario\\source\\repos\\LibreriaOnline\\App_Data\\LibreriaOnline.mdf; " +
                  "Integrated Security = True";
        }

        public bool createCritica(ENCritica en) {
            SqlConnection connection = new SqlConnection(conexionCritica);

            try {
                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into Critica (Titulo, texto, nota, email,ISBN) VALUES " +
                                                "('" + en.getTitulo() + "','" + en.getTexto() + "','" + en.getNota() + "','" + "juan@gcloud.es" + "','" + "11111111" + "')", connection);
                com.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool deleteCritica(ENCritica en) {
            return true;
        }
        public bool updateCritica(ENCritica en) {
            return true;
        }
        public bool buscarCritica(ENCritica en) {
            return true;
        }
    }
}
