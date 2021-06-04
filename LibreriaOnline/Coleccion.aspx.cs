using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Coleccion : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Nueva_Coleccion(object sender, EventArgs e) {
            Response.Redirect("NuevaColeccion.aspx");
        }

        protected void Mod_Coleccion(object sender, EventArgs e) {
            Response.Redirect("ModificarColeccion.aspx");
        }

        protected void Borrar_Coleccion(object sender, EventArgs e) {
            Response.Redirect("BorrarColeccion.aspx");
        }
    }
}