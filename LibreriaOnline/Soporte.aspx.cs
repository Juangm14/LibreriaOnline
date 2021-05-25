using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Soporte : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void Enviar_Click(object sender, EventArgs e) {
            if(DropDownList1.SelectedValue== "Pregunta")
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
                else {
                    MsgSoporte.Text = "Error inesperado, intentalo mas tarde.";
                }
            }
        }

        protected void EnviarSugerencia(object sender, EventArgs e)
        {

        }
    }
}