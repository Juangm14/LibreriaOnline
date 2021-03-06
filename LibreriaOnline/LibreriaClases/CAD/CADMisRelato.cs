using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.CAD {
    class CADMisRelato {

        private String conexionRelato;
        public CADMisRelato() {
            conexionRelato = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }

        public bool createRelato(ENMisRelato en) {
            SqlConnection connection = new SqlConnection(conexionRelato);

            try {
                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into Relato (Titulo, genero, text, email) VALUES " +
                                                "('" + en.getTitulo() + "','" + en.getGenero() + "','" + en.getTexto() + "','" + en.getUsuario() + "')", connection);
                com.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool deleteRelato(ENMisRelato en) {
            SqlConnection connection = new SqlConnection(conexionRelato);
            String sql = "Delete from Relato where Titulo = ('" + en.getTitulo() + "')";
            try {
                connection.Open();
                SqlCommand c = new SqlCommand(sql, connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool updateRelato(ENMisRelato en) {
            SqlConnection connection = new SqlConnection(conexionRelato);
            String sql = "update Relato set  Titulo = '{0}', genero = '{1}', text = '{2}' where Titulo = '{0}'";
            try {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getTitulo(), en.getGenero().ToString(), en.getTexto() }), connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool bucarRelato(ENMisRelato en) {
            SqlConnection connection = new SqlConnection(conexionRelato);
            String sql = "select Titulo from Relato where Titulo = '{0}'";

            try {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getTitulo() }), connection);
                SqlDataReader reader = c.ExecuteReader();

                if (reader.Read()) {
                    if (reader["Titulo"].ToString().Equals(en.getTitulo())) return true;
                } else { 
                    return false;
                }
                connection.Close();
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            return false;
        }
        public DataSet listarMisRelatos(ENMisRelato en) {
            DataSet bdvirtual = new DataSet();

            SqlConnection c = new SqlConnection(conexionRelato);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Relato where email = " + "('" + en.getUsuario() + "')", c);

            da.Fill(bdvirtual, "Relato");

            return bdvirtual;
        }
    }
}
