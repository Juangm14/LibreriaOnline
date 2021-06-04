using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClases.EN;
using System.Data.SqlClient;
using System.Data;

namespace LibreriaClases.CAD {
    public class CADCarrito {

        public string constring;

        public CADCarrito() {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True"; 
        }

        public bool comprobarCarrito(ENCarrito en) {
            SqlConnection connection = new SqlConnection(constring);
            string sql = "Select * from Carrito where ISBN = '{0}'";
            try {
                connection.Open();
                SqlCommand com = new SqlCommand(string.Format(sql, en.ISBN), connection);
                SqlDataReader dr = com.ExecuteReader();
                if(dr.Read()) {
                    return true;
                }
                return false;
            } catch(SqlException ex) {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public bool agregarElementoCarrito(ENCarrito en) {
            SqlConnection connection = new SqlConnection(constring);

            if (comprobarCarrito(en)) {
                return false;
            }

            string sql = "Select * from libros where ISBN = '{0}'";
            string imagen = "", titulo = "", precio = "";

            try {
                connection.Open();
                SqlCommand com = new SqlCommand(string.Format(sql, en.ISBN), connection);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read()) {
                    imagen = dr["imagen"].ToString();
                    titulo = dr["titulo"].ToString();
                    precio = dr["precio"].ToString();
                }
                connection.Close();

                connection.Open();
                SqlCommand com2 = new SqlCommand("Insert Into Carrito (email, ISBN, titulo, imagen, precio, Cantidad) VALUES " +
                                                "('" + en.Usuario + "','" + en.ISBN + "','" + titulo + "','" + imagen + "','" + precio + "','" + en.Cantidad + "')", connection);
                int filasAfectadas = com2.ExecuteNonQuery();
                if (filasAfectadas > 0) {
                    return true;
                }
                connection.Close();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }

            return false;
        }
        public DataSet listarElementosCarrito(ENCarrito en) {
            DataSet bdvirtual = new DataSet();

            SqlConnection connection = new SqlConnection(constring);
            SqlDataAdapter adapter = new SqlDataAdapter("Select *  from Carrito where email = " + "('" + en.Usuario + "')", connection);

            adapter.Fill(bdvirtual, "Carrito");

            return bdvirtual;
        }
        public bool eliminarElementoCarrito(ENCarrito en) {

            SqlConnection connection = new SqlConnection(constring);
            string sql = "Delete from carrito where isbn = " + "('"  + en.ISBN + "')";

            try {
                connection.Open();
                SqlCommand com = new SqlCommand(sql, connection);
                int filasAfectadas = com.ExecuteNonQuery();
                if (filasAfectadas > 0) {
                    return true;
                } else {
                    return false;
                }
            } catch (SqlException ex) {
                Console.WriteLine(ex.ToString());
            }
                
            return false;
        }
        public bool modificarElementoCarrito(ENCarrito en) {

            SqlConnection connection = new SqlConnection(constring);
            string sql = "update carrito set cantidad = " + "('" + en.Cantidad + "') where isbn = " + "('" + en.ISBN + "') and email = " + "('" + en.Usuario + "')";

            try {
                connection.Open();
                SqlCommand com = new SqlCommand(sql, connection);
                int filasAfectadas = com.ExecuteNonQuery();
                if (filasAfectadas > 0) {
                    return true;
                } else {
                    return false;
                }
            } catch (SqlException ex) {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }
    }
}
