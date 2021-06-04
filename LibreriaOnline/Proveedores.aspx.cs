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
            LabelRegistroEmail.Visible = false;
            TextRegistroEmail.Visible = false;
            LabelRegistroNombre.Visible = false;
            TextRegistroNombre.Visible = false;
            LabelRegistroTelefono.Visible = false;
            TextRegistroTelefono.Visible = false;
            LabelRegistroContraseña.Visible = false;
            TextRegistroContraseña.Visible = false;
            LabelRegistroContraseña2.Visible = false;
            TextRegistroContraseña2.Visible = false;
            ButtonRegistro2.Visible = false;
            LabelEmail.Visible = true;
            TextEmail.Visible = true;
            LabelContraseña.Visible = true;
            TextContraseña.Visible = true;
        }
        protected void Registro_Click(object sender, EventArgs e)
        {
            LabelRegistroEmail.Visible = true;
            TextRegistroEmail.Visible = true;
            LabelRegistroNombre.Visible = true;
            TextRegistroNombre.Visible = true;
            LabelRegistroTelefono.Visible = true;
            TextRegistroTelefono.Visible = true;
            LabelRegistroContraseña.Visible = true;
            TextRegistroContraseña.Visible = true;
            LabelRegistroContraseña2.Visible = true;
            TextRegistroContraseña2.Visible = true;
            ButtonRegistro2.Visible = true;
            ButtonRegistro.Visible = false;
            LabelEmail.Visible = false;
            TextEmail.Visible = false;
            LabelContraseña.Visible = false;
            TextContraseña.Visible = false;
            ButtonInicio.Visible = false;

            if (TextRegistroEmail.Text == "" || TextRegistroNombre.Text == "" || TextRegistroTelefono.Text=="" || TextRegistroContraseña.Text == "" || TextRegistroContraseña2.Text == "")
            {
                Msg.Text = "Algun campo obligatorio esta vacio.";
            }else if (TextRegistroEmail.Text.Contains("@gmail.com"))
            {
                Msg.Text = "El correo es incorrecto, es necesario un dominio propio.";
            }
            else if (TextRegistroContraseña.Text != TextRegistroContraseña2.Text)
            {
                Msg.Text = "La contraseña repetida no coincide con la contraseña introducida.";
            }
            else
            {
                ENProveedores ProveedorEmail = new ENProveedores();
                ProveedorEmail.setEmail(TextRegistroEmail.Text);;
                if (ProveedorEmail.EmailRepetido())
                {
                    Msg.Text = "El email introducido ya esta en uso. Por favor, introduzca un email diferente.";
                }
                else
                {
                    ENProveedores ProveedorFinal = new ENProveedores();
                    ProveedorFinal.setEmail(TextRegistroEmail.Text);
                    ProveedorFinal.setContraseña(TextRegistroContraseña.Text);
                    ProveedorFinal.setNombre(TextRegistroNombre.Text);
                    ProveedorFinal.setTelefono(int.Parse(TextRegistroTelefono.Text));
                    if (ProveedorFinal.Registrar())
                    {
                        Msg.Text = "Proveedor creado con exito";
                        Session.Add("email", ProveedorFinal.getEmail());
                    }
                    else
                    {
                        Msg.Text = "Error inesperado. Intentelo de nuevo.";
                    }
                }
            }

        }
        protected void InicioSesion_Click(object sender, EventArgs e)
        {
            if (LabelEmail.Text == "")
            {
                Msg.Text = "Email no introducido.";
            }
            else if (LabelContraseña.Text == "")
            {
                Msg.Text = "Contraseña no introducida.";
            }
            else
            {
                ENProveedores en = new ENProveedores();
                en.setEmail(LabelEmail.Text.ToString());
                en.setContraseña(LabelContraseña.Text.ToString());
                if (en.Log())
                {
                    Msg.Text = "Se ha iniciado sesión correctamente.";
                    Session.Add("email", LabelEmail.Text.ToString());
                    Response.Redirect("Libros.aspx");
                }
                else
                {
                    Msg.Text = "No se ha podido iniciar sesión. Compruebe que ha escrito bien la contraseña o el email";
                }
            }
        }
    }
}