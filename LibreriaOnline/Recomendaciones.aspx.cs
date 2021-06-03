using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class Recomendaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comprobamos que el usuario tiene la sesión iniciada
            if (Session["email"] == null)
            {
                //Sino esta iniciado no sacamos nada y le decimos que se inicie para obtenerlo todo
                Label1.Text = "Para obtener todas las funcionalidades inicia sesión, ";
                mensajeSession.Visible = true;
                Grid.Visible = false;
                ListaLibros.Visible = false;
                NuevaReco.Visible = false;
                bsubtitulo.Visible = false;
                bTitulo.Visible = false;
            }
            else
            {
                //No mostamos el botón para que inicie sesión cuando ya esta iniciado
                mensajeSession.Visible = false;
            }
        }
            

        protected void BuscReco(object sender, EventArgs e)
        {
            //Creamos un EN para controlar las funcionalidades
            ENRecomendaciones recomend = new ENRecomendaciones();
            recomend.Genero = ListaLibros.SelectedValue;
            if (recomend.Recomendado())
            {
                //Si el género esta bien redirijimos a la otra web y le pasamos el género por QueryString
                Response.Redirect("RecomenGenero.aspx?genero=" + ListaLibros.SelectedValue + "");
            }
            else
            {
                Label1.Text = "Error al realizar la busqueda, sentimos las molestias.";
            }
        }

        protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}