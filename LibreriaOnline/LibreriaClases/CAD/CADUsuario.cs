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
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";//ruta de la cadena de conexión de la base de datos
        }
        public bool modificardatosUsuario(ENUsuario en)
        {

            return true;
        }
        public SqlDataReader mostrardatos(ENUsuario en)//Mostramos los datos cuando estamos en perfil
        {
            SqlConnection juan = new SqlConnection(constring);
            String sql = "select * from usuario  where email = '{0}'";//Hacemos una sentencia select donde mostrara todos los datos correspondientes a ese email
            try
            {
                juan.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getEmail() }), juan);//Con el string.format le pasamos los parametros necesarios a la sentencia sql para que esta se ejecute, el email
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
        public bool deleteUsuario(ENUsuario en)//Eliminaremos el usuario
        {
            SqlConnection connection = new SqlConnection(constring);
            
            try
            {
                String sql = "Delete from Usuario where email = ('" + en.getEmail() + "')";//Haremos una sentencia delete de toda la tabla usuario donde se encuentre ese email
                connection.Open();
                SqlCommand c = new SqlCommand(sql, connection);
               c.ExecuteNonQuery();
                connection.Close();
              
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);//Da error y mostraremos el mensaje 
                return false;
            }
            finally { connection.Close(); }
            return true;
        }
        public bool updateUsuario(ENUsuario en)//En el updtate primeramente haremos una sentencia sql en el que modificaremos los datos

        {
            
            SqlConnection connection = new SqlConnection(constring);//Creamos un sql conection y hacemos una sentencia update
            String sql = "update Usuario set  nick = '{0}', direccion = '{1}', telefono = '{2}', contraseña = '{3}',nombre='{4}',apellidos='{5}',imagen='{7}' where email = '{6}'";//Los números han de corresponderse con la posición en el siguiente sql command
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(string.Format(sql, new String[] { en.getNick(), en.getDireccion(), en.getTelefono(), en.getContraseña(),en.getNombre(),en.getApellidos(),en.getEmail(),en.image_ }), connection);//
                int filasAfectadas = c.ExecuteNonQuery();//Recoge el numero de filas del update (sql command)
                connection.Close();
                if (filasAfectadas > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);//Haremos que se muestre un mensaje de error
                return false;
            }
        }

      

        internal bool modificarUsuario(ENUsuario eNUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
