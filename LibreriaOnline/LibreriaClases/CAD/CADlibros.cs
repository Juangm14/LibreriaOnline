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

        public bool createLibros(ENlibros en)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into Libros (ISBN,Autores,Titulo,Editorial,Genero,Proveedor,Precio) VALUES " +
                                              "('" + en.getISBN() + "','" + en.getAutores() + "','" + en.getTitulo() + "','" + en.getEditorial() + "','" + en.getGenero() + "','" + en.getProveedor() + "','" + en.getPrecio() + /*en.Imagen +*/ "')", connection);
               
                com.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            return true;
        }

        public bool deleteLibros(ENlibros en)
        {
            return true;
        }

        public bool updatelibros(ENlibros en)
        {
            return true;
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

        public bool addLibro(ENlibros en) {
            throw new NotImplementedException();
        }

        public bool updateLibros(ENlibros eNlibros) {
            throw new NotImplementedException();
        }
    }
}
