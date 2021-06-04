using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LibreriaOnline
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)//Se muestren los datos cuando entramos al perfil 
        {
            
            if (!IsPostBack)//
            {
                mostrarEdad.ReadOnly = true;
                mostrarDireccion.ReadOnly = true;
                mostrarEmail.ReadOnly = true;
                mostrarNombre.ReadOnly = true;
                mostrarDireccion.ReadOnly = true;
                mostrarApellido.ReadOnly = true;
                mostrarNick.ReadOnly = true;
                mostrarTelefono.ReadOnly = true;
                mostrarContraseña.ReadOnly = true;
                GuardarUsuario.Visible = false;
                ElimUsuario.Visible = false;
                formFileSm.Visible = false;
                fotoperfil.Visible = true;

                ENUsuario en = new ENUsuario(Session["email"].ToString());
                SqlDataReader s = en.mostrardatos();
                if (s.Read())
                {
                    mostrarContraseña.Text = s["contraseña"].ToString();
                    mostrarEmail.Text = s["email"].ToString();
                    mostrarNombre.Text = s["nombre"].ToString();
                    mostrarApellido.Text = s["apellidos"].ToString();
                    mostrarNick.Text = s["nick"].ToString();
                    mostrarTelefono.Text = s["telefono"].ToString();
                    mostrarEdad.Text = s["edad"].ToString();
                    mostrarDireccion.Text = s["direccion"].ToString();
                    fotoperfil.ImageUrl = s["imagen"].ToString();
                    
                }

            }


        }
        
        
        protected void editar_Click(object sender, EventArgs e)//Con el boton de editar que algunos campos se puedan modificar y otros no
        {
            mostrarEdad.ReadOnly = true;
            mostrarDireccion.ReadOnly = false;
            mostrarEmail.ReadOnly = true;
            mostrarNombre.ReadOnly = false;
            mostrarDireccion.ReadOnly = false;
            mostrarApellido.ReadOnly = false;
            mostrarNick.ReadOnly = false;
            mostrarTelefono.ReadOnly = false;
            mostrarContraseña.ReadOnly = false;
            GuardarUsuario.Visible = true;
            ElimUsuario.Visible = true;
            mostrarNick.Text = "";
            fotoperfil.Visible = true;
            formFileSm.Visible = true;
            ENUsuario en = new ENUsuario(Session["email"].ToString());


            SqlDataReader s = en.mostrardatos();//Llamammos al mostrar datos para que nos salgan los datos correspondientes
            if (s.Read())
            {
                mostrarContraseña.Text = s["contraseña"].ToString();
                mostrarEmail.Text = s["email"].ToString();
                mostrarNombre.Text = s["nombre"].ToString();
                mostrarApellido.Text = s["apellidos"].ToString();
                mostrarNick.Text = s["nick"].ToString();
                mostrarTelefono.Text = s["telefono"].ToString();
                mostrarEdad.Text = s["edad"].ToString();
                mostrarDireccion.Text = s["direccion"].ToString();
                fotoperfil.ImageUrl = s["imagen"].ToString();
                
            }

            



        }
      
        protected void GuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!formFileSm.Text.Equals("")) {//Si el campo de poner la url de la imagen esta vacio que de error

                try
                {
                    ENUsuario en = new ENUsuario(fotoperfil.ImageUrl = "~/imagenesPerfil/" + formFileSm.Text, mostrarDireccion.Text.ToString(), mostrarNick.Text.ToString(), mostrarTelefono.Text.ToString(), mostrarContraseña.Text.ToString(), mostrarNombre.Text.ToString(), mostrarApellido.Text.ToString(), Session["email"].ToString());//Guardamos los datos en la base de datos 

                    if (en.updateUsuario())//Modificamos los datos
                    {

                        Response.Redirect("Perfil.aspx");//Redirigimos a perfil cuando le demos a guardar
                    }
                    else
                    {
                        GuardarUsuario.Visible = true;
                        GuardarUsuario.Text = "El usuario no ha podido ser modificado, intentelo de nuevo.";
                    }
                }
                catch (FormatException ex)
                {
                    GuardarUsuario.Visible = true;
                    GuardarUsuario.Text = " ERROR: " + ex.Message.ToString();
                }
            }
            else
            {
                GuardarUsuario.Visible = true;
                GuardarUsuario.Text = " ERROR: No has rellenado todos los campos obligatorios ";
                
            }
        }
        protected void EliminarUsuario_Click(object sender, EventArgs e)//Eliminamos usuario 
        {

            ENUsuario en = new ENUsuario(mostrarEmail.Text);
           
          
                
                if (en.deleteUsuario())//Llamos al delete con su sentencia para borrar
                {

                Response.Redirect("SignIn.aspx");//Cuando elimine se redirija al signin
                }
                else
                {
                    ElimUsuario.Visible = true;
                    ElimUsuario.Text = "El usuario no se ha podido eliminar.";//Muestre mensaje de error si no se ha podido eliminar
                }
            
            }
        }

    }
