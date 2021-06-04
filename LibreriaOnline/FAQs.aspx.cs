using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LibreriaOnline.EN;


namespace LibreriaOnline {
    public partial class FAQs : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) { //Carga el grid con las preguntas frecuentes respondidas por los administradores.
            DataSet datos = new DataSet();
            ENSoporte en = new ENSoporte();
            datos = en.Lista();
            GridView1.DataSource = datos;
            GridView1.DataBind();
        }
    }
}