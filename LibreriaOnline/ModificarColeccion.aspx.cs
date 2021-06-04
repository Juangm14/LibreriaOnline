using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class ModificarColeccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Modificar_Coleccion(object sender, EventArgs e)
        {
            try
            {
                ENColeccion en = new ENColeccion();
                en.nombre = Mod1.Text;
                en.getId();
                en.nombre = Mod2.Text;
                if (en.updateColeccion())
                    Label.Text = "La colección se ha modificado";
                else
                    Label.Text = "La colección no se ha podido modificar";
            }
            catch (FormatException)
            {
                Label.Text = "Indica un nombre";
            }
        }
    }
}