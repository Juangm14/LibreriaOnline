using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaOnline.EN;

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

        protected void Nueva_Puntuacion(object sender, EventArgs e)
        {
            try
            {
                ENListaUsuario en = new ENListaUsuario();
                en.usuario = Session["email"].ToString();
                en.libro = ListaLibros.Text.ToString();
                if (ListaPuntuacion != null)
                    en.nota = int.Parse(ListaPuntuacion.Text.ToString());
                if (en.addListaUsuario())
                    Msg.Text = "El libro se ha marcado como leído";
                else
                    Msg.Text = "El libro no se ha podido marcar como leído";
            }
            catch (FormatException)
            {
                Msg.Text = "Selecciona un libro";
            }
        }

        protected void Mod_Puntuacion(object sender, EventArgs e)
        {
            try
            {
                ENListaUsuario en = new ENListaUsuario();
                en.usuario = Session["email"].ToString();
                en.libro = ListaLibros.Text.ToString();
                en.nota = int.Parse(ListaPuntuacion.Text.ToString());
                if (en.updateListaUsuario())
                    Msg.Text = "La puntuacion se ha modificado";
                else
                    Msg.Text = "La puntuacion no se ha podido modificar";
            }
            catch (FormatException)
            {
                Msg.Text = "Rellena todos los parametros";
            }
        }

        protected void Elim_Puntuacion(object sender, EventArgs e)
        {
            try
            {
                ENListaUsuario en = new ENListaUsuario();
                en.usuario = Session["email"].ToString();
                en.libro = ListaLibros.Text.ToString();
                if (en.removeListaUsuario())
                    Msg.Text = "El libro se ha eliminado de leídos";
                else
                    Msg.Text = "El libro no se ha podido eliminar de leídos";
            }
            catch (FormatException)
            {
                Msg.Text = "Selecciona un libro";
            }
        }
    }
}