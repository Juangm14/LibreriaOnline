using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOnline.EN;

namespace LibreriaOnline.CAD
{
    class CADUsuario
    {
        private string constring;
        public CADUsuario()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }
        public bool modificardatosUsuario(ENUsuario en)
        {


            return true;
        }
        public SqlDataReader mostrardatos(ENUsuario en)
        {
            SqlConnection juan = new SqlConnection(constring);
            String sql = "select * from usuario  where email = '{0}'";
            try
            {
                juan.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getEmail() }), juan);
                SqlDataReader reader = c.ExecuteReader();


                return reader;

                
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return null;
            }

        }
       
        public bool createUsuario(ENUsuario en)
        {
            return true;
        }
        public bool readUsuario(ENUsuario en)
        {
            return true;
        }
        public bool deleteUsuario(ENUsuario en)
        {
            SqlConnection connection = new SqlConnection(constring);
            
            try
            {
                String sql = "Delete from Usuario where email = ('" + en.getEmail() + "')";
                connection.Open();
                SqlCommand c = new SqlCommand(sql, connection);
               c.ExecuteNonQuery();
                connection.Close();
              
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            finally { connection.Close(); }
            return true;
        }
        public bool updateUsuario(ENUsuario en)

        {
            
            SqlConnection connection = new SqlConnection(constring);
            String sql = "update Usuario set  nick = '{0}', direccion = '{1}', telefono = '{2}', contraseña = '{3}' where email = '{4}'";
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getNick(), en.getDireccion(), en.getTelefono(), en.getContraseña(),en.getEmail() }), connection);
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

      

        internal bool modificarUsuario(ENUsuario eNUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
