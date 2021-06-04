using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

public class CADListaUsuario
{
	private string constring;

	public CADListaUsuario()
	{
		constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LibreriaOnline.mdf;Integrated Security=True";
	}

    public bool addListaUsuario(ENListaUsuario en)
    {
        bool added = true;
        string s;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com1 = new SqlCommand("Select ISBN from Libros where titulo = ('" + en.libro + "')", c);
            SqlDataReader libro = com1.ExecuteReader();

            if (libro.Read())
            {
                en.libro = libro["isbn"].ToString();
                c.Close();
            }
            c.Open();
            if (en.nota != 0)
                s = "Insert into Leidos (email,ISBN,Nota) VALUES ('" + en.usuario + "'," + en.libro + "," + en.nota + ")";
            else
                s = "Insert into Leidos (email,ISBN) VALUES ('" + en.usuario + "'," + en.libro + ")";
            SqlCommand com2 = new SqlCommand(s, c);
            if (com2.ExecuteNonQuery() == 0)
                added = false;
        }
        catch (SqlException ex)
        {
            added = false;
            Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
        }
        finally { c.Close(); }

        return added;
    }

    public bool removeListaUsuario(ENListaUsuario en)
	{
        bool deleted = true;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Delete from Leidos where email='" + en.usuario + "' and ISBN=" + en.libro, c);
            if (com.ExecuteNonQuery() == 0)
                deleted = false;
        }
        catch (SqlException ex)
        {
            deleted = false;
            Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
        }
        finally { c.Close(); }
        
        return deleted;
    }

	public bool updateListaUsuario(ENListaUsuario en)
	{
        bool updated = true;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Update Leidos set Nota=" + en.nota + " where email='" + en.usuario + "' and ISBN="+ en.libro, c);
            if (com.ExecuteNonQuery() == 0)
                updated = false;
        }
        catch (SqlException ex)
        {
            updated = false;
            Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
        }
        finally { c.Close(); }
      
        return updated;
    }
}
