using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Registro_Click(object sender, EventArgs e)
        {
            if (registroEmail.Text == "" || registroNombre.Text == "" || registroTelefono.Text=="" || registroContraseña.Text == "" || registroContraseña2.Text == "")
            {
                Msg.Text = "Algun campo obligatorio esta vacio.";
            }
            else if (registroContraseña.Text != registroContraseña2.Text)
            {
                Msg.Text = "La contraseña repetida no coincide con la contraseña introducida.";
            }
            else
            {
                ENProveedores ProveedorEmail = new ENProveedores();
                ProveedorEmail.setEmail(registroEmail.Text);;
                if (ProveedorEmail.EmailRepetido())
                {
                    Msg.Text = "El email introducido ya esta en uso. Por favor, introduzca un email diferente.";
                }
                else
                {
                    ENProveedores ProveedorFinal = new ENProveedores();
                    ProveedorFinal.setEmail(registroEmail.Text);
                    ProveedorFinal.setContraseña(registroContraseña.Text);
                    if (registroNombre.Text != "")
                    {
                        ProveedorFinal.setNombre(registroNombre.Text);
                    }
                    if (registroTelefono.Text != "")
                    {
                        ProveedorFinal.setTelefono(int.Parse(registroTelefono.Text));
                    }
                    if (ProveedorFinal.Registrar())
                    {
                        Msg.Text = "Usuario creado con exito";
                        Session.Add("email", ProveedorFinal.getEmail());
                        Response.Redirect("Home.aspx");
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