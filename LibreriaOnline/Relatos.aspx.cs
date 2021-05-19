﻿using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Relatos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //Ocultamos el formulario de creacion de Relato
            exampleFormControlInput1.Visible = false;
            GeneroDesplegable.Visible = false;
            exampleFormControlInput2.Visible = false;
            TituloRelato.Visible = false;
            TextoRelato.Visible = false;
            GeneroRelato.Visible = false;
            CrearRelatoButton.Visible = false;
            LabelCrear.Visible = false;

            //Ocultamos el formulario de modificacion de Relato
            ModLabelTitulo.Visible = false;
            ModBuscarTitulo.Visible = false;
            ModButton.Visible = false;
            ModDropDownList1.Visible = false;
            ModGenero.Visible = false;
            ModLabelTexto.Visible = false;
            ModTextTexto.Visible = false;
            ModTextTitulo.Visible = false;
            ModTextNewTitulo.Visible = false;
            ModLabelNewTitulo.Visible = false;
            ModMsgBuscar.Visible = false;
            ModLabelUpdateRelato.Visible = false;

            //Ocultamos el formulario de eliminacion de Relato
            ElimLabelRelato.Visible = false;
            ElimTituloRelato.Visible = false;
            ElimBotonRelato.Visible = false;
            ElimMsg.Visible = false;

            //Ocultamos la vista de los relatos
            GridRelatosShow.Visible = true;
        }

        protected void NuevoRelato_Click(object sender, EventArgs e) {
            exampleFormControlInput1.Visible = true;
            GeneroDesplegable.Visible = true;
            exampleFormControlInput2.Visible = true;
            TituloRelato.Visible = true;
            TextoRelato.Visible = true;
            GeneroRelato.Visible = true;
            CrearRelatoButton.Visible = true;

            GridRelatosShow.Visible = false;
        }


        protected void EditarRelato_Click(object sender, EventArgs e) {
            ModLabelTitulo.Visible = true;
            ModTextTitulo.Visible = true;
            ModBuscarTitulo.Visible = true;
            GridRelatosShow.Visible = false;
        }

        protected void BuscarRelato_Click(object sender, EventArgs e) {
            GridRelatosShow.Visible = false;
            try {
                ENRelato en = new ENRelato();
                en.setTitulo(ModTextTitulo.Text.ToString());
                if (en.bucarRelato()) {
                    ModButton.Visible = true;
                    ModDropDownList1.Visible = true;
                    ModGenero.Visible = true;
                    ModLabelTexto.Visible = true;
                    ModTextTexto.Visible = true;
                    ModTextNewTitulo.Visible = true;
                    ModLabelNewTitulo.Visible = true;
                } else {
                    ModMsgBuscar.Visible = true;
                    ModMsgBuscar.Text = "<br> No existe ese Relato, intentalo de nuevo.";
                }
            } catch (Exception ex) {
                ModMsgBuscar.Visible = true;
                ModMsgBuscar.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }

        protected void BorrarRelato_Click(object sender, EventArgs e) {
            ElimLabelRelato.Visible = true;
            ElimTituloRelato.Visible = true;
            ElimBotonRelato.Visible = true;
            GridRelatosShow.Visible = false;
        }
        protected void CrearNuevoRelato_Click(object sender, EventArgs e) {
            try {
                 ENRelato en = new ENRelato(exampleFormControlInput1.Text.ToString(), GeneroDesplegable.Text.ToString(), exampleFormControlInput2.Text.ToString());
                if (en.createRelato()) {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br> El relato se ha creado correctamente";
                } else {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br> El relato no se ha creado, intentalo de nuevo.";
                }
            } catch (FormatException ex) {
                LabelCrear.Visible = true;
                LabelCrear.Text = "<br> ERROR: " + ex.Message.ToString();
            }

        }

        protected void ModificarRelato_Click(object sender, EventArgs e) {
            GridRelatosShow.Visible = false;
            ENRelato en = new ENRelato(ModTextNewTitulo.Text.ToString(), ModDropDownList1.Text.ToString(), ModTextTexto.Text.ToString());
            try {
                if (en.updateRelato()) {
                    ModLabelUpdateRelato.Visible = true;
                    ModLabelUpdateRelato.Text = "<br>El relato ha sido modificado correctamente.";
                } else {
                    ModLabelUpdateRelato.Visible = true;
                    ModLabelUpdateRelato.Text = "<br>El relato no ha podido ser modificado, intentelo de nuevo.";
                }
            } catch (FormatException ex) {
                ModLabelUpdateRelato.Visible = true;
                ModLabelUpdateRelato.Text = "<br> ERROR: " + ex.Message.ToString();
            }

        }

        protected void EliminarRelato_Click(object sender, EventArgs e) {
            GridRelatosShow.Visible = false;
            ElimMsg.Visible = true;
            try {
                ENRelato en = new ENRelato();
                en.setTitulo(ElimTituloRelato.Text.ToString());
                if (en.deleteRelato()) {
                    ElimMsg.Visible = true;
                    ElimMsg.Text = "<br>Relato eliminado correctamente.";
                } else {
                    ElimMsg.Visible = true;
                    ElimMsg.Text = "<br>El relato no se ha podido eliminar.";
                }
            } catch (FormatException ex) {
                ElimMsg.Visible = true;
                ElimMsg.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }

    }
}