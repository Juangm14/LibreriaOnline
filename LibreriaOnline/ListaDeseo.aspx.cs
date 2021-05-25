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
            ENListaDeseos listDeseo = new ENListaDeseos();
            string aux = ListaLibros.SelectedValue;
            listDeseo.Usuario = Session["email"].ToString();
            if (listDeseo.addDeseado(aux))
            {
                Response.Redirect("ListaDeseo.aspx");
            }
            else
            {
                Label1.Text = "Ya tienes marcado ese libro como deseado, fijate bien.";
            }
        }

        protected void EliminarLibro(object sender, EventArgs e)
        {
            ENListaDeseos listDeseo = new ENListaDeseos();
            string aux = ListaLibros.SelectedValue;
            if (listDeseo.removeDeseado(aux))
            {
                Response.Redirect("ListaDeseo.aspx");
            }
            else
            {
                Label1.Text = "No tienes marcado ese libro como deseado, fijate bien.";
            }
        }

    }
}