using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class SignIn : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Msg.Text = ""; //Inicializa el label a una cadena vacia
        }

        protected void InicioSesion_Click(object sender, EventArgs e) {
            if (logUsuario.Text == "") { //Comprueba que no este vacio el campo usuario
                Msg.Text = "Email o nick no introducido.";
            }
            else if(logContrasena.Text == "") //Comprueba que no este vacio el campo contraseña
            {
                Msg.Text = "Contraseña no introducida.";
            }
            else
            {
                ENRegistro usuario = new ENRegistro();
                usuario.Nick = logUsuario.Text;
                usuario.Email = logUsuario.Text;
                usuario.Contrasena = logContrasena.Text;
                if (usuario.Log()) //Intenta iniciar sesión. Si el usuario ha escrito bien sus credenciales y no ocurre ningun error inesperado en la base de datos, se iniciara sesión.
                {
                    Msg.Text = "Se ha iniciado sesión correctamente.";
                    Session.Add("email", usuario.Email); //Se añade el email a Session
                    Response.Redirect("Home.aspx"); //Se redirige a la pagina Home
                }
                else
                {
                    Msg.Text = "No se ha podido iniciar sesión. Compruebe que ha escrito bien la contraseña, el email o el nick.";
                }
            }
        }

    }
}