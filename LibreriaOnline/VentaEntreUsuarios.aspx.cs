using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LibreriaOnline
{
    public partial class VentaEntreUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                DataSet datos = new DataSet();
                if (Session["email"] != null) //Si no se ha iniciado sesion, se esconden las funcionalidades y avisa de que inicies sesion.
                {
                    //Cargamos el grid con los datos
                    NuevaOferta.Visible = true;
                    BorrarOferta.Visible = true;
                    ComprarOferta.Visible = true;
                    problema.Visible = false;
                    TextBoxOferta.Visible = true;
                    mensajeSession.Visible = false;
                    ENVentaUsu en = new ENVentaUsu();
                    datos = en.Lista();
                    GridView1.DataSource = datos;
                    GridView1.DataBind();
                    

                }
                else
                {
                    TextBoxOferta.Visible = false;
                    NuevaOferta.Visible = false;
                    BorrarOferta.Visible = false;
                    ComprarOferta.Visible = false;
                    problema.Visible = true;
                    problema.Text = "<br> Para tener el acceso completo a esta funcionalidad inicia sesion ";
                    mensajeSession.Visible = true;

                }
           
        }
        protected void CrearOfertaClick(object sender, EventArgs e) //Redirige a la pagina de creacion de oferta
        {
            Response.Redirect("CrearOfertaUsu.aspx"); 
        }

        protected void BorrarOfertaClick(object sender, EventArgs e) //Borra la oferta deseada si pertenece al usuario que esta intentando borrarla. 
        {
            
            if (TextBoxOferta.Text == "") //Comprueba que no este vacia la textbox
            {
                Msg.Text = "Por favor, introduzca el id de la oferta en la que esta interesado.";
            }
            else
            {
                ENVentaUsu oferta = new ENVentaUsu();
                oferta.Id = int.Parse(TextBoxOferta.Text);
                if (oferta.Leer()) //Comprueba que existe la oferta.
                {
                    if (oferta.Usuario == Session["email"].ToString()) //Comprueba que la oferta a borrar pertenece al usuario
                    {
                        if (oferta.Borrar()) //Si todo sale bien, se borrara de la base de datos.
                        {
                            Msg.Text = "La oferta se ha borrado exitosamente.";
                        }
                        else
                        {
                            Msg.Text = "La oferta no se ha borrado exitosamente.";
                        }
                    }
                    else
                    {
                        Msg.Text = "La oferta a borrar no pertenece a esta cuenta.";
                    }

                }
                else
                {
                    Msg.Text = "La oferta a borrar no existe.";
                }
            }
        }

        protected void ComprarOfertaClick(object sender, EventArgs e) //Añade al carrito la oferta
        {
            if (TextBoxOferta.Text == "") //Comprueba que no este vacia la textbox
            {
                Msg.Text = "Por favor, introduzca el id de la oferta en la que esta interesado.";
            }
            else
            {
                ENVentaUsu oferta = new ENVentaUsu();
                oferta.Id = int.Parse(TextBoxOferta.Text);
                if (oferta.Leer()) //Comprueba que existe la oferta.
                {
                    if (oferta.Usuario != Session["email"].ToString())
                    {
                        //AÃ±adimos al carrito de alguna manera
                        Msg.Text = "Oferta añadida al carrito";
                    }
                    else
                    {
                        Msg.Text = "Estas intentando comprar tu propia oferta.";
                    }
                }
                else
                {
                    Msg.Text = "La oferta a comprar no existe.";
                }
            }
        }
    }
}