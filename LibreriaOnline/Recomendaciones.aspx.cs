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

        }

        protected void BuscReco(object sender, EventArgs e)
        {
            ENRecomendaciones recomend = new ENRecomendaciones();
            recomend.Genero = ListaLibros.SelectedValue;
            if (recomend.Recomendado())
            {
                Response.Redirect("RecomenGenero.aspx?genero="+ ListaLibros.SelectedValue + "");
            }
            else
            {
                Label1.Text = "Error al realizar la busqueda, sentimos las molestias.";
            }
        }
    }
}