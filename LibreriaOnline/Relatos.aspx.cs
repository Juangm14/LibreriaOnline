using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaClases.EN;
using LibreriaOnline.EN;

namespace LibreriaOnline {
    public partial class Relatos : System.Web.UI.Page {

        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e) {
            LabelError.Visible = false;
            mensajeSession.Visible = false;
            if (!Page.IsPostBack) {
                try {
                    if (Session["Email"] != null) {
                        LabelError.Visible = false;
                        ENRelato en = new ENRelato(Session["email"].ToString());

                        d = en.ListarRelato();
                        GridRelato.DataSource = d;
                        GridRelato.DataBind();
                    } else {
                        LabelError.Visible = true;
                        LabelError.Text = "<br> Para tener el acceso completo a esta funcionalidad inicia sesion, ";
                        mensajeSession.Visible = true;
                    }
                } catch (Exception ex) {
                    LabelError.Visible = true;
                    LabelError.Text = "<br> ERROR: " + ex.Message.ToString();
                }
            }
        }
    } 
}