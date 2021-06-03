using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline
{
    public partial class RecomenGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string generoP = Request.QueryString["genero"];
            Label2.Text = "Los libros que te podrían interesar del género " + generoP + " son:";
        }
    }
}