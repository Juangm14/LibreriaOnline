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
            conexionCritica = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }

        

        public bool createCritica(ENCritica en) {
            SqlConnection connection = new SqlConnection(conexionCritica);
            String isbn = null;
            try {
                connection.Open();
                SqlCommand s = new SqlCommand("Select ISBN from Libros where titulo = ('" + en.getLibro() + "')", connection);
                SqlDataReader libro  = s.ExecuteReader();

                if (libro.Read()) {
                    isbn = libro["isbn"].ToString();
                    connection.Close();
                }

                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into Critica (Titulo, texto, nota, email, ISBN) VALUES " +
                                              "('" + en.getTitulo() + "','" + en.getTexto() + "','" + en.getNota() + "','" + en.getUsuario() + "','" + isbn + "')", connection);
                com.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public bool deleteCritica(ENCritica en) {
            SqlConnection connection = new SqlConnection(conexionCritica);
            String sql = "Delete from Critica where titulo = '{0}' and email = '{1}'";
            try {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getTitulo(), en.getUsuario() }), connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool updateCritica(ENCritica en) {
            SqlConnection connection = new SqlConnection(conexionCritica);
            String sql2 = "update Critica set  titulo = '{0}', texto = '{1}', nota ='{2}' where Titulo = '{0}' and email = '{3}'";
            try {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql2, new String[] { en.getTitulo(), en.getTexto().ToString(), en.getNota().ToString(), en.getUsuario()}), connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }
        public bool buscarCritica(ENCritica en) {
            SqlConnection connection = new SqlConnection(conexionCritica);
            String sql = "select titulo from Critica where Titulo = '{0}' and email = '{1}'";
            try {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getTitulo(), en.getUsuario() }), connection);
                SqlDataReader reader = c.ExecuteReader();

                if (reader.Read()) {
                    if (reader["titulo"].ToString().Equals(en.getTitulo())) return true;
                } else { return false; }
                connection.Close();
            } catch (SqlException ex) {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            return false;
        }
    }
}
