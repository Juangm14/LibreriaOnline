using LibreriaClases.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Carrito : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                if (Session["Email"] != null) {
                    ENCarrito en = new ENCarrito(Session["email"].ToString());
                    DataSet data = en.listarElementosCarrito();

                    DataList2.DataSource = data;
                    DataList2.DataBind();
                } else {
                    mensajeSession.Visible = true;
                    mensajeSession.Text = "<br> Para tener el acceso completo a esta funcionalidad inicia sesion, ";
                    mensajeSession.Visible = true;
                }
            } catch (Exception ex) {
                mensajeSession.Visible = true;
                mensajeSession.Text = ex.ToString();
            }

        }

        protected void agregar(object sender, CommandEventArgs e) {
            string cantidad="1";

            string info = e.CommandArgument.ToString();
            string[] arg = new string[3];
            char[] splitter = { ';' };
            arg = info.Split(splitter);

            cantidad = (int.Parse(arg[0]) + int.Parse(arg[1])).ToString();

            ENCarrito en = new ENCarrito(arg[2], Session["email"].ToString(),cantidad);

            en.modificarElementoCarrito();

            Response.Redirect("Carrito.aspx");
        }

        protected void eliminarElemento_Command(object sender, CommandEventArgs e) {


            ENCarrito en = new ENCarrito(e.CommandArgument.ToString(), Session["email"].ToString());
            en.eliminarElementoCarrito();

        }
    }
}