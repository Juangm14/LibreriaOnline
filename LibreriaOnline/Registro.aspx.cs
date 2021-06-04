using LibreriaOnline;
using LibreriaOnline.EN;
using System;
namespace LibreriaOnline
{
    public partial class Registro : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Msg.Text = ""; //Inicializa el label a una cadena vacia
        }

        protected void Registro_Click(object sender, EventArgs e) { //Registra al usuario 
            if(registroEmail.Text=="" || registroNick.Text=="" || registroContraseña.Text=="" || registroContraseña2.Text == "") //Comprueba que los campos obligatorios no esten vacios.
            {
                Msg.Text = "Algun campo obligatorio esta vacio.";
            }
            else if (registroContraseña.Text != registroContraseña2.Text) //Comprueba que el campo de contraseña y el campo de repetir contraseña coincidan.
            {
                Msg.Text = "La contraseña repetida no coincide con la contraseña introducida.";
            }
            else
            {
                ENRegistro usuarioEmail = new ENRegistro();
                usuarioEmail.Email = registroEmail.Text;
                ENRegistro usuarioNick = new ENRegistro();
                usuarioNick.Nick = registroNick.Text;
                if (usuarioEmail.EmailRepetido()) //Comprueba si el email con el que se esta intentado hacer el registro no este vinculado ya a otra cuenta.
                {
                    Msg.Text = "El email introducido ya esta en uso. Por favor, introduzca un email diferente.";
                }
                else if(usuarioNick.NickRepetido()) //Comprueba si el nick con el que se esta intentado hacer el registro no este vinculado ya a otra cuenta.
                {
                    Msg.Text = "El nick introducido ya esta en uso. Por favor, introduzca un nick diferente";
                }
                else
                {
                    ENRegistro usuarioFinal = new ENRegistro(); //Hace el registro
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
                    if (usuarioFinal.Registrar()) //Si no hay ningun error en la base de datos, crea el usuario.
                    {
                        Msg.Text = "Usuario creado con exito";
                        Session.Add("email", usuarioFinal.Email); //Añade el email a Session para que se inicie sesion automaticamente
                        Response.Redirect("Home.aspx"); //Redirige a la pagina Home.
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