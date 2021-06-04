using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class RecomenGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Pillamos el género que se ha pasado por QueryString y imprimos el mensaje y el gridView
            string generoP = Request.QueryString["genero"];
            Label2.Text = "Los libros que te podrían interesar del género " + generoP + " son:";
        }

        protected void PaVolver(object sender, EventArgs e)
        {
            //Botón básico para volver a recomendaciones
            Response.Redirect("Recomendaciones.aspx");
        }
    }
}