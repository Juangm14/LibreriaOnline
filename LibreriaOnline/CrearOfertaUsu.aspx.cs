using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class CrearOfertaUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //Si el usuario intenta entrar sin iniciar sesion, se le redirigira a la pantalla de inicio de sesión.
        {
            if (Session["email"] == null)
            {
                Response.Redirect("SignIn.aspx");
            }
           
        }

        protected void NuevaOfertaClick(object sender, EventArgs e) //Crea la oferta 
        {
            if (TextBoxPrecio.Text == "" || TextBoxISBN.Text == "") //Comprueba si hay algun campo vacio
            {
                Msg.Text = "hay algun campo sin rellenar";
            }
            else
            {
                ENVentaUsu oferta = new ENVentaUsu();
                oferta.Precio = float.Parse(TextBoxPrecio.Text);
                oferta.Libro = int.Parse(TextBoxISBN.Text);
                oferta.Usuario = Session["email"].ToString();
                if (oferta.Insertar())
                {
                    Response.Redirect("VentaEntreUsuarios.aspx");
                }
                else
                {
                    Msg.Text = "Error inesperado, por favor, intentelo de nuevo.";
                }
            }
        }
    }
}