using System;
using LibreriaOnline;
using LibreriaOnline.EN;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class ListaDeseo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Anyadir_Click(object sender, EventArgs e)
        {
            //Creamos el EN para comprobar la funcionalidad
            ENListaDeseos listDeseo = new ENListaDeseos();
            string aux = ListaLibros.SelectedValue;
            listDeseo.Usuario = Session["email"].ToString(); //Añadimos el libro
            if (listDeseo.addDeseado(aux))
            {
                //Si el libro se ha añadido recargamos la página para que el GridView se actualice
                Response.Redirect("ListaDeseo.aspx");
            }
            else
            {
                //Si ya lo tenemos añadido imprimimos un mensaje de error
                Label1.Text = "Ya tienes marcado ese libro como deseado, fijate bien.";
            }
        }

        protected void EliminarLibro(object sender, EventArgs e)
        {
            //Creamos el EN para comprobar la funcionalidad
            ENListaDeseos listDeseo = new ENListaDeseos();
            string aux = ListaLibros.SelectedValue;
            if (listDeseo.removeDeseado(aux))
            {
                //Si el libro se ha añadido recargamos la página para que el GridView se actualice
                Response.Redirect("ListaDeseo.aspx");
            }
            else
            {
                //Si no lo tenemos añadido imprimimos un mensaje de error
                Label1.Text = "No tienes marcado ese libro como deseado, fijate bien.";
            }
        }

    }
}