using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace LibreriaOnline
{
    public class CADVentaUsu
    {
        private String constring;
        public CADVentaUsu()
        {
            constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
        }
        public DataSet Lista() //Devuelve un dataset de las ofertas para nuestro grid.
        {
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlConnection c = new SqlConnection(constring);
                SqlDataAdapter da = new SqlDataAdapter("Select id, ISBN, precio from VentaUsu", c);

                da.Fill(bdvirtual, "Ofertas");
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            return bdvirtual;
        }

        public bool Leer(ENVentaUsu oferta) //Lee una oferta
        {
            bool encontrado = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from [dbo].[VentaUsu] Where id=" + oferta.Id.ToString(), c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    oferta.Usuario = dr["email"].ToString();
                    oferta.Precio = float.Parse(dr["precio"].ToString());
                    oferta.Libro = int.Parse(dr["ISBN"].ToString());
                    encontrado = true;
                }
                dr.Close();
                c.Close();
            }
            catch (SqlException e)
            {
                encontrado = false;
                Console.WriteLine("Error, libro no encontrado: {0}", e.Message);
            }

            return encontrado;
        }

        public bool Insertar(ENVentaUsu param) //Crea una nueva oferta
        {
            bool anyadido = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open(); //Primero se conecta con la BBDD
                string dinero = param.Precio.ToString();
                dinero=dinero.Replace(",", ".");
                string command = "Insert INTO VentaUsu (email, ISBN, precio) VALUES ('" + param.Usuario + "', '" + param.Libro + "', (" + dinero + "))";
                SqlCommand com = new SqlCommand(command, c);
                com.ExecuteNonQuery(); //Y ejecuta cada uno su respectivo comando
                anyadido = true; //Si todo sale bien se devuelve true y no se ha lanzado ninguna excepcion
                c.Close();
            }
            catch (SqlException e)
            {
                //Esta rodeado de try/catch para capturar las posibles excepcion que se produzcan
                anyadido = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return anyadido;
        }

        public bool Borrar(ENVentaUsu oferta) //Borra una oferta 
        {
            bool eliminado = false;
            if (!oferta.Leer())
            {
                Console.WriteLine("Error, id no introducido o inexistente");
            }
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Delete from [dbo].[VentaUsu] Where id=" + oferta.Id.ToString(), c);
                com.ExecuteNonQuery();
                eliminado = true;
                c.Close();
            }
            catch (SqlException e)
            {
                eliminado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return eliminado;
        }
    }

 
}