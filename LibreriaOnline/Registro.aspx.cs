using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Registro : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Msg.Text = "";
        }

        protected void Registro_Click(object sender, EventArgs e) {
            if(registroEmail.Text=="" || registroNick.Text=="" || registroContraseña.Text=="" || registroContraseña2.Text == "")
            {
                Msg.Text = "Algun campo obligatorio esta vacio.";
            }
            else if (registroContraseña.Text == registroContraseña2.Text)
            {
                Msg.Text = "La contraseña repetida no coincide con la contraseña introducida.";
            }
            else
            {
                ENRegistro usuarioEmail = new ENRegistro();
                usuarioEmail.Email = registroEmail.Text;
                ENRegistro usuarioNick = new ENRegistro();
                usuarioNick.Nick = registroNick.Text;
                if (usuarioEmail.EmailRepetido())
                {
                    Msg.Text = "El email introducido ya esta en uso. Por favor, introduzca un email diferente.";
                }
                if (usuarioNick.NickRepetido())
                {
                    Msg.Text = "El nick introducido ya esta en uso. Por favor, introduzca un nick diferente";
                }
                else
                {
                    ENRegistro usuarioFinal = new ENRegistro();
                    usuarioFinal.Email = registroEmail.Text;
                    usuarioFinal.Nick = registroNick.Text;
                    usuarioFinal.Contrasena = registroContraseña.Text;
                    if (registroEdad.Text != "")
                    {
                        usuarioFinal.Edad = int.Parse(registroEdad.Text);
                    }
                    if (registroTelefono.Text != "")
                    {
                        usuarioFinal.Telefono = int.Parse(registroTelefono.Text);
                    }
                    if (usuarioFinal.Registrar())
                    {
                        Msg.Text = "Usuario creado con exito";
                    }
                    else
                    {
                        Msg.Text = "Error inesperado. Intentelo de nuevo.";
                    }
                }
            }

        }
    }
}