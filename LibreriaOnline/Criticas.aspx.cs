using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Criticas : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //Creacion de Critica
            NuevoTituloLabel.Visible = false;
            NuevoTituloCritica.Visible = false;
            NuevoTextoLabel.Visible = false;
            NuevoTextoCritica.Visible = false;
            EnviarNuevaCritica.Visible = false;
            NuevaValidacionLabel.Visible = false;
            NuevaValoracionText.Visible = false;
            ConfirmacionNuevaCritica.Visible = false;

            //Modificacion de Critica
            ModTituloLabel.Visible = false;
            ModTituloText.Visible = false;
            ModTextoLabel.Visible = false;
            ModTextoText.Visible = false;
            ModButton.Visible = false;
            ModBuscarTituloLabel.Visible = false;
            ModBuscarTituloText.Visible = false;
            ModBuscarTituloBoton.Visible = false;
            ModValoracionText.Visible = false;
            ModValoracionLabel.Visible = false;
            ConfirmarModificacionCritica.Visible = false;
            ConfirmarBusquedaCritica.Visible = false;

            //Eliminacion de Critica
            ElimBuscarLabel.Visible = false;
            ElimBuscarText.Visible = false;
            ElimBuscarBoton.Visible = false;
            ConfirmarEliminacionCritica.Visible = false;

            //Grid de critica
            GridCritica.Visible = false;
        }

        protected void desplegarNuevaCritica(object sender, EventArgs e) {
            GridCritica.Visible = false;
            NuevoTituloLabel.Visible = true;
            NuevoTituloCritica.Visible = true;
            NuevoTextoLabel.Visible = true;
            NuevoTextoCritica.Visible = true;
            EnviarNuevaCritica.Visible = true;
            NuevaValidacionLabel.Visible = true;
            NuevaValoracionText.Visible = true;
        }

        protected void desplegarModCrit_Click(object sender, EventArgs e) {
            GridCritica.Visible = false;
            ModBuscarTituloLabel.Visible = true;
            ModBuscarTituloText.Visible = true;
            ModBuscarTituloBoton.Visible = true;


        }

        protected void desplegarElimCrit_Click(object sender, EventArgs e) {
            GridCritica.Visible = false;
            ElimBuscarLabel.Visible = true;
            ElimBuscarText.Visible = true;
            ElimBuscarBoton.Visible = true;
        }
        protected void NuevaCritica_Click(object sender, EventArgs e) {
            GridCritica.Visible = false;
            try {
                ENCritica en = new ENCritica(NuevoTituloCritica.Text.ToString(), NuevoTextoCritica.Text.ToString(), NuevaValoracionText.Text.ToString());
                if (en.createCritica()) {
                    ConfirmacionNuevaCritica.Visible = true;
                    ConfirmacionNuevaCritica.Text = "<br> La critica se ha creado correctamente";
                } else {
                    ConfirmacionNuevaCritica.Visible = true;
                    ConfirmacionNuevaCritica.Text = "<br> La critica no se ha creado, intentalo de nuevo.";
                }
            } catch (FormatException ex) {
                ConfirmacionNuevaCritica.Visible = true;
                ConfirmacionNuevaCritica.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }

        protected void ModBuscarTituloBoton_Click(object sender, EventArgs e) {
             GridCritica.Visible = false;
            try {
                ENCritica en = new ENCritica();
                en.setTitulo(ModTituloText.Text.ToString());
                if (en.buscarCritica()) {
                    ModTituloLabel.Visible = true;
                    ModTituloText.Visible = true;
                    ModTextoLabel.Visible = true;
                    ModTextoText.Visible = true;
                    ModButton.Visible = true;
                    ModValoracionText.Visible = true;
                    ModValoracionLabel.Visible = true;
                } else {
                    //ModMsgBuscar.Visible = true;
                    //ModMsgBuscar.Text = "<br> No existe ese Relato, intentalo de nuevo.";
                }
            } catch (Exception ex) {
                //ModMsgBuscar.Visible = true;
                //ModMsgBuscar.Text = "<br> ERROR: " + ex.Message.ToString();
            }

        }
    }
}