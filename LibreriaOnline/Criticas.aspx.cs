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
            LabelNuevoLibro.Visible = false;
            ListaNuevosLibros.Visible = false;

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
            ModLabelListaLibros.Visible = false;
            ModListaLibros.Visible = false;

            //Eliminacion de Critica
            ElimBuscarLabel.Visible = false;
            ElimBuscarText.Visible = false;
            ElimBuscarBoton.Visible = false;
            ConfirmarEliminacionCritica.Visible = false;

            //Grid de critica
            if (Session["email"] == null) {
                ConfirmacionNuevaCritica.Visible = true;
                DesplegarEliminacion.Visible = false;
                DesplegarCritica.Visible = false;
                DesplegarModificacion.Visible = false;
                MsgCritica.Visible = true;
                GridCritica.Visible = false;
                MsgCritica.Text = "<br> Para tener el acceso completo a esta funcionalidad inicia sesion, ";
                mensajeSession.Visible = true;
            } else {
                GridCritica.Visible = true;
                DesplegarEliminacion.Visible = true;
                DesplegarCritica.Visible = true;
                DesplegarModificacion.Visible = true;
                mensajeSession.Visible = false;
            }
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
            LabelNuevoLibro.Visible = true;
            ListaNuevosLibros.Visible = true;
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
                ENCritica en = new ENCritica(NuevoTextoCritica.Text.ToString(), NuevoTituloCritica.Text.ToString(), NuevaValoracionText.Text.ToString(), Session["email"].ToString(), ListaNuevosLibros.Text.ToString());
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
                ENCritica en = new ENCritica(Session["email"].ToString());
                en.setTitulo(ModBuscarTituloText.Text.ToString());
                if (en.buscarCritica()) {
                    ModTituloLabel.Visible = true;
                    ModTituloText.Visible = true;
                    ModTextoLabel.Visible = true;
                    ModTextoText.Visible = true;
                    ModButton.Visible = true;
                    ModValoracionText.Visible = true;
                    ModValoracionLabel.Visible = true;
                    ModLabelListaLibros.Visible = true;
                    ModListaLibros.Visible = true;
                } else {
                    ConfirmarModificacionCritica.Visible = true;
                    ConfirmarModificacionCritica.Text = "<br> No existe esa critica, intentalo de nuevo.";
                }
            } catch (Exception ex) {
                ConfirmarBusquedaCritica.Visible = true;
                ConfirmarBusquedaCritica.Text = "<br> ERROR: " + ex.Message.ToString();
            }

        }
        protected void ModificarCritica_Click(object sender, EventArgs e){
            GridCritica.Visible = false;
            ENCritica en = new ENCritica(ModTextoText.Text.ToString(), ModTituloText.Text.ToString(), ModValoracionText.Text.ToString(), Session["email"].ToString(), ModListaLibros.ToString());
            try {
                if (en.updateCritica()) {
                    ConfirmarModificacionCritica.Visible = true;
                    ConfirmarModificacionCritica.Text = "<br>La critica ha sido modificado correctamente.";
                } else {
                    ConfirmarModificacionCritica.Visible = true;
                    ConfirmarModificacionCritica.Text = "<br>La critica no ha podido ser modificado, intentelo de nuevo.";
                }
            } catch (FormatException ex) {
                ConfirmarModificacionCritica.Visible = true;
                ConfirmarModificacionCritica.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }

        protected void ElimBuscarBoton_Click(object sender, EventArgs e) {
            GridCritica.Visible = false;
            try {
                ENCritica en = new ENCritica(Session["email"].ToString());
                en.setTitulo(ElimBuscarText.Text.ToString());
                if (en.deleteCritica()) {
                    ConfirmarEliminacionCritica.Visible = true;
                    ConfirmarEliminacionCritica.Text = "<br> La critica se ha eliminado correctamente.";
                } else {
                    ConfirmarEliminacionCritica.Visible = true;
                    ConfirmarEliminacionCritica.Text = "<br> No existe ese Critica, intentalo de nuevo.";
                }
            } catch (Exception ex) {
                ConfirmarBusquedaCritica.Visible = true;
                ConfirmarBusquedaCritica.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }
    }
}