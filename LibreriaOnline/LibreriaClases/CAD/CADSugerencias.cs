using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibreriaOnline.CAD {
    public class CADSugerencias {
       
        private string constring;


        public CADSugerencias() {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }

        public bool createSugerencia(ENSugerencias en) {
            {
                bool creado = false;
                try
                {
                    SqlConnection c = new SqlConnection(constring);
                    c.Open();
                    SqlCommand com = new SqlCommand("Insert INTO Sugerencia(titulo, texto) VALUES ('" + en.Titulo + "', '" + en.Texto + "')", c);
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