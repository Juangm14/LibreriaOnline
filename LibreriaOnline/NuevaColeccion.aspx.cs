using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class NuevaColeccion : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Nueva_Coleccion(object sender, EventArgs e)
        {
            try
            {
                ENColeccion en = new ENColeccion();
                en.nombre = pass.Text.ToString();
                if (en.findLibros())
                {
                    en.nombre = cp.Text;
                    if (en.addColeccion())
                        Label.Text = "La colección se ha añadido";
                    else
                        Label.Text = "La colección no se ha podido añadir";
                }
                else
                    Label.Text = "No existe el libro indicado";
            }
            catch (FormatException)
            {
                Label.Text = "Indica un nombre";
            }
        }
    }
}