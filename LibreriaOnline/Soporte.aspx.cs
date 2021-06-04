using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class Soporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Pregunta")
            {
                EnviarPregunta(sender, e);
            }
            else
            {
                EnviarSugerencia(sender, e);
            }
        }

        protected void EnviarPregunta(object sender, EventArgs e)
        {
            if (AsuntoTextBox.Text == "")
            {
                MsgSoporte.Text = "Por favor, introduzca un asunto.";
            }
            else if (PreguntaTextBox.Text == "")
            {
                MsgSoporte.Text = "Por favor, introduzca una pregunta.";
            }
            else
            {
                ENSoporte pregunta = new ENSoporte();
                pregunta.Pregunta = PreguntaTextBox.Text;
                pregunta.Asunto = AsuntoTextBox.Text;
                if (pregunta.createPregunta())
                {
                    MsgSoporte.Text = "Pregunta enviada a soporte.";
                    PreguntaTextBox.Text = "";
                    AsuntoTextBox.Text = "";
                }
                else
                {
                    MsgSoporte.Text = "Error inesperado, intentalo mas tarde.";
                }
            }
        }

        protected void EnviarSugerencia(object sender, EventArgs e)//Enviamos la sugerencia 
        {
            {
                if (AsuntoTextBox.Text == "")
                {
                    MsgSoporte.Text = "Por favor, introduzca un asunto.";//Pedimos que nos introduzca el asunto 
                }
                else if (PreguntaTextBox.Text == "")
                {
                    MsgSoporte.Text = "Por favor, introduzca una sugerencia.";
                }
                else
                {
                    ENSugerencias sugerencia = new ENSugerencias();
                    sugerencia.Texto = PreguntaTextBox.Text;
                    sugerencia.Titulo = AsuntoTextBox.Text;
                    if (sugerencia.createSugerencia())//Llamamos al cad para que introduzca los datos en la base de datos
                    {
                        MsgSoporte.Text = "Pregunta enviada a soporte.";//Mensaje de confirmación de que se ha enviado correctamente
                        PreguntaTextBox.Text = "";
                        AsuntoTextBox.Text = "";
                    }
                    else
                    {
                        MsgSoporte.Text = "Error inesperado, intentalo mas tarde.";//Mostramos error si no se ha podido añadir a la base de datos 
                    }
                }
            }

        }
    }
}