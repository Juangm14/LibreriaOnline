using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class SignIn : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Msg.Text = "";
        }

        protected void InicioSesion_Click(object sender, EventArgs e) {
            if (logUsuario.Text == "") {
                Msg.Text = "Email o nick no introducido.";
            }
            else if(logContrasena.Text == "")
            {
                Msg.Text = "Contraseña no introducida.";
            }
            else
            {
                ENRegistro usuario = new ENRegistro();
                usuario.Nick = logUsuario.Text;
                usuario.Email = logUsuario.Text;
                usuario.Contrasena = logContrasena.Text;
                if (usuario.log())
                {
                    Msg.Text = "Se ha iniciado sesión correctamente.";
                }
                else
                {
                    Msg.Text = "No se ha podido iniciar sesión. Compruebe que ha escrito bien la contraseña, el email o el nick.";
                }
            }
        }

    }
}