using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Leidos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            Msg.Visible = true;
            LabelLibro.Visible = false;
            LabelNota.Visible = false;
            ListaLibros.Visible = false;
            ListaPuntuacion.Visible = false;

            //Creación de leídos
            AñadirPuntuacion.Visible = false;

            //Modificación de leídos
            ModificarPuntuacion.Visible = false;

            //Eliminación de leídos
            EliminarPuntuacion.Visible = false;

            //Grid de leídos
            if (Session["email"] == null)
            {
                GridLeidos.Visible = false;
                NuevoLibroLeido.Visible = false;
                ModLibroLeido.Visible = false;
                ElimLibroLeido.Visible = false;
            }
            else
            {
                GridLeidos.Visible = true;
                NuevoLibroLeido.Visible = true;
                ModLibroLeido.Visible = true;
                ElimLibroLeido.Visible = true;
            }
        }

        protected void Libro_Leido(object sender, EventArgs e)
        {
            GridLeidos.Visible = false;
            NuevoLibroLeido.Visible = false;
            ModLibroLeido.Visible = false;
            ElimLibroLeido.Visible = false;
            LabelLibro.Visible = true;
            ListaLibros.Visible = true;
            AñadirPuntuacion.Visible = true;
            ListaPuntuacion.Visible = true;
            Msg.Visible = false;
        }

        protected void Mod_Libro_Leido(object sender, EventArgs e)
        {
            GridLeidos.Visible = false;
            NuevoLibroLeido.Visible = false;
            ModLibroLeido.Visible = false;
            ElimLibroLeido.Visible = false;
            LabelLibro.Visible = true;
            ListaLibros.Visible = true;
            ModificarPuntuacion.Visible = true;
            ListaPuntuacion.Visible = true;
            Msg.Visible = false;
        }

        protected void Libro_No_Leido(object sender, EventArgs e)
        {
            GridLeidos.Visible = false;
            NuevoLibroLeido.Visible = false;
            ModLibroLeido.Visible = false;
            ElimLibroLeido.Visible = false;
            LabelLibro.Visible = true;
            ListaLibros.Visible = true;
            EliminarPuntuacion.Visible = true;
            Msg.Visible = false;
        }
    }
}