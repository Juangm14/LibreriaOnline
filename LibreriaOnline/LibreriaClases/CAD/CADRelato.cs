using LibreriaClases.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.CAD {
    public class CADRelato {

        private string constring;
        public CADRelato() {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }

        public DataSet ListarRelatos(ENRelato en) {
            DataSet bdvirtual = new DataSet();

            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Relato where email != " + "('" + en.getEmail()  + "')", c);
           
            da.Fill(bdvirtual, "Relato");

            return bdvirtual;
        }

    }
}
