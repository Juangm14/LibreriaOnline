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
            if(DropDownList1.SelectedValue== "Pregunta") //Si es una pregunta, llama a la funcion de pregunta. Si no, llamara a la funcion de sugerencia.
            {
                EnviarPregunta(sender, e);
            }
            else
            {
                EnviarSugerencia(sender, e); 
            }
        }

        protected void EnviarPregunta(object sender, EventArgs e) //Envia una pregunta a los administradores. Una vez sea respondida, se publicara en la pagina de preguntas frecuentes.
        {
            if (AsuntoTextBox.Text == "") //Comprueba que no este vacio el campo de asunto
            {
                MsgSoporte.Text = "Por favor, introduzca un asunto.";
            }
            else if (PreguntaTextBox.Text == "") //Comprueba que no este vacio el campo de pregunta
            {
                MsgSoporte.Text = "Por favor, introduzca una pregunta.";
            }
            else
            {
                ENSoporte pregunta = new ENSoporte();
                pregunta.Pregunta = PreguntaTextBox.Text;
                pregunta.Asunto = AsuntoTextBox.Text;
                if (pregunta.createPregunta()) //Envia la pregunta a la base de datos, donde sera respondida por los administradores.
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