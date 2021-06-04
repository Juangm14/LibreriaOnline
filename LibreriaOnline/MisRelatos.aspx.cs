using LibreriaOnline.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class MisRelatos : System.Web.UI.Page {
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
            if (Session["email"] == null) {
                GridRelatosShow.Visible = false;
                NuevoRelato.Visible = false;
                EditarRelato.Visible = false;
                BorrarRelato.Visible = false;
                MsgRelato.Visible = true;
                MsgRelato.Text = "<br> Para tener el acceso completo a esta funcionalidad inicia sesion, ";
                mensajeSession.Visible = true;
            } else {
                GridRelatosShow.Visible = true;
                NuevoRelato.Visible = true;
                EditarRelato.Visible = true;
                BorrarRelato.Visible = true;
                mensajeSession.Visible = false;
            }

            ListarRelatos();

        }

        protected void NuevoRelato_Click(object sender, EventArgs e) {
            exampleFormControlInput1.Visible = true;
            GeneroDesplegable.Visible = true;
            exampleFormControlInput2.Visible = true;
            TituloRelato.Visible = true;
            TextoRelato.Visible = true;
            GeneroRelato.Visible = true;
            CrearRelatoButton.Visible = true;
            MsgRelato.Visible = false;
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
                ENMisRelato en = new ENMisRelato(Session["email"].ToString());
                if (ModTextTitulo.Text.Length != 0) {
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
                } else {
                    ModMsgBuscar.Visible = true;
                    ModMsgBuscar.Text = "<br>ERROR: No ha introducido ningun dato.";
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

            String usuario = null;

            if (Session["email"] != null) {

                usuario = Session["email"].ToString();
                if (exampleFormControlInput1.Text.Length != 0) {
                    try {
                        ENMisRelato en = new ENMisRelato(exampleFormControlInput1.Text.ToString(), GeneroDesplegable.Text.ToString(), exampleFormControlInput2.Text.ToString(), usuario);
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
                } else {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br>ERROR: El relato no se ha creado, introduce un titulo.";
                }
            } else {
                Response.Redirect("Signin.aspx");
            }

        }

        protected void ModificarRelato_Click(object sender, EventArgs e) {
            GridRelatosShow.Visible = false;
            ENMisRelato en = new ENMisRelato(ModTextNewTitulo.Text.ToString(), ModDropDownList1.Text.ToString(), ModTextTexto.Text.ToString());
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
            if (ElimTituloRelato.Text.Length != 0) {
                try {
                    ENMisRelato en = new ENMisRelato(Session["email"].ToString());
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
            } else {
                ElimMsg.Visible = true;
                ElimMsg.Text = "<br>ERROR: Introduce el titulo del relato a borrar.";
            }
        }

        protected void ListarRelatos() {
            ENMisRelato en = new ENMisRelato(Session["email"].ToString());
            DataSet data = en.listarMisRelatos();
            GridRelatosShow.DataSource = data;
            GridRelatosShow.DataBind();

        }
    }
}