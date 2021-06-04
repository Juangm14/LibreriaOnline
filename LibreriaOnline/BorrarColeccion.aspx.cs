using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class BorrarColeccion : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Borrar_Coleccion(object sender, EventArgs e)
        {
            try
            {
                ENColeccion en = new ENColeccion();
                en.nombre = borrarColeccion.Text;
                if (en.removeColeccion())
                    Label.Text = "La colección se ha borrado";
                else
                    Label.Text = "No existe ninguna colección con ese nombre";
            }
            catch (FormatException)
            {
                Label.Text = "Indica un nombre";
            }
        }
    }
}