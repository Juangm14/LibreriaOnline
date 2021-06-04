using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.CAD
{
    class CADlibros
    {
        string cadenaConexion;
        public CADlibros()
        {
            cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }

        public bool CreateLibros(ENlibros en)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into Libros (ISBN,Autores,Titulo,Editorial,Genero,Proveedor,Precio, imagen) VALUES " +
                                              "('" + en.getISBN() + "','" + en.getAutores() + "','" + en.getTitulo() + "','" + en.getEditorial() + "','" + en.getGenero() + "','" + en.getProveedor() + "','" + en.getPrecio() + "','" + en.getImagen() + "')", connection);

                com.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public bool deleteLibros(ENlibros en)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            String sql = "Delete from Libros where ISBN = ('" + en.getISBN().ToString() + "')";
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(sql, connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public bool updateLibros(ENlibros en)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            String sql = "update Libros set  ISBN = '{0}', Autores = '{1}', Titulo = '{2}', Editorial = '{3}', Genero = '{4}', Proveedor = '{5}', Precio = '{6}' where ISBN = '{0}'";
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getISBN().ToString(), en.getAutores(), en.getTitulo(), en.getEditorial(), en.getGenero(), en.getProveedor(), en.getPrecio().ToString(), en.getImagen()}), connection);
                int filasAfectadas = c.ExecuteNonQuery();
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
        }

        public bool buscarLibro(ENlibros en)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            String sql = "select ISBN from Libros where ISBN = '{0}'";
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getISBN().ToString() }), connection);
                SqlDataReader reader = c.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["ISBN"].ToString().Equals(en.getISBN().ToString())) return true;
                }
                else { return false; }
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            return false;
        }

        public bool adminLibros(ENlibros en)
        {
            return true;
        }

        public bool ColeccionLibros(ENlibros en)
        {
            return true;
        }

        public bool CriticaLibros(ENlibros en)
        {
            return true;
        }

        public bool CompraLibros(ENlibros en)
        {
            return true;
        }
        public bool NotaLibros(ENlibros en)
        {
            return true;
        }

        public bool RecomiendaLibros(ENlibros en)
        {
            return true;
        }
        public bool relUsuarioLibros(ENlibros en)
        {
            return true;
        }
    }
}
