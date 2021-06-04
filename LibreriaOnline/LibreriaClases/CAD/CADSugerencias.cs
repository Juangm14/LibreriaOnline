using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibreriaOnline.CAD {
    public class CADSugerencias {//Sugerencia no se elimina ni modifica
       
        private string constring;


        public CADSugerencias() {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";//Ruta de la cadena de conexión de la base de datos
        }

        public bool createSugerencia(ENSugerencias en) {//creamos la sugerencia 
            {
                bool creado = false;
                try
                {
                    SqlConnection c = new SqlConnection(constring);
                    c.Open();
                    SqlCommand com = new SqlCommand("Insert INTO Sugerencia(titulo, texto) VALUES ('" + en.Titulo + "', '" + en.Texto + "')", c);//sentencia insent para introducir el texto dentro de la base de datos. Correspondiente a titulo(asunto) y texto(pregunta)
                    com.ExecuteNonQuery();
                    creado = true;
                    c.Close();
                }
                catch (SqlException e)
                {
                    creado = false;
                    Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                }
                return creado;
            }

        }

        public bool readSugerencia(ENSugerencias en) {
            return true;
        }

        public bool updateSugerencia(ENSugerencias en) {
            return true;
        }

        public bool deleteSugerencia(ENSugerencias en) {
            return true;
        }
    }
}