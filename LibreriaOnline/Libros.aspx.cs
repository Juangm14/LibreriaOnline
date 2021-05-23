using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace LibreriaOnline
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelCrear.Visible = false;
            LabelTitulo.Visible = false;
            Titulo.Visible = false;
            TextTitulo.Visible = false;
            ISBN.Visible = false;
            TextISBN.Visible = false;
            Genero.Visible = false;
            TextGenero.Visible = false;
            Autores.Visible = false;
            TextAutores.Visible = false;
            Editorial.Visible = false;
            TextEditorial.Visible = false;
            Precio.Visible = false;
            TextPrecio.Visible = false;
            Proveedor.Visible = false;
            TextProveedor.Visible = false;
            TextBox1.Visible = false;
            ModLabelISBN.Visible = false;
            ModTextISBN.Visible = false;
            ModGenero.Visible = false;
            ModBuscarISBN.Visible = false;
            GeneroLibro.Visible = false;
            GeneroDesplegable.Visible = false;
            ModLabelISBN.Visible = false;
            ModTextISBN.Visible = false;
            ModBuscarISBN.Visible = false;
            ModMsgBuscar.Visible = false;
            ModLabelNewAutor.Visible = false;
            ModTextNewAutor.Visible = false;
            ModGenero.Visible = false;
            ModDropDownList1.Visible = false;
            ModLabelEditorial.Visible = false;
            ModTextEditorial.Visible = false;
            ModLabelPrecio.Visible = false;
            ModTextPrecio.Visible = false;
            ModButton.Visible = false;
            Boton_crearLibro.Visible = false;
            ElimLabelLibro.Visible = false;
            ElimISBNLibro.Visible = false;
            ElimBotonLibro.Visible = false;
            ElimMsg.Visible = false;
            /*GridRelatosShow.Visible = true;*/
        }
        protected void Boton_crear(object sender, EventArgs e)
        {
            try
            {
                ENlibros en = new ENlibros(TextISBN.Text, TextAutores.Text, TextTitulo.Text, TextEditorial.Text, TextGenero.Text, TextProveedor.Text, float.Parse(TextPrecio.Text), "");
                if (en.CreateLibros())
                {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br>Libro creado correctamente";
                }
                else
                {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br>No se ha podido crear el libro. Introduce los datos correctamente";
                }
               
            }catch (FormatException ex)
            {
                LabelCrear.Visible = true;
                LabelCrear.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }
        protected void NuevoLibro_Click(object sender, EventArgs e)
        {
            LabelCrear.Visible = true;
            LabelTitulo.Visible = true;
            TextTitulo.Visible = true;
            ISBN.Visible = true;
            TextISBN.Visible = true;
            Genero.Visible = true;
            TextGenero.Visible = true;
            Autores.Visible = true;
            TextAutores.Visible = true;
            Editorial.Visible = true;
            TextEditorial.Visible = true;
            Precio.Visible = true;
            TextPrecio.Visible = true;
            Proveedor.Visible = true;
            TextProveedor.Visible = true;

        }
        protected void EditarLibro_Click(object sender, EventArgs e)
        {
            ModLabelISBN.Visible = true;
            ModTextISBN.Visible = true;
            ModBuscarISBN.Visible = true;
            /*GridRelatosShow.Visible = false;*/
        }

        protected void BuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                ENlibros en = new ENlibros(null,"juan@juan.com");
                en.setISBN(int.Parse(ModTextISBN.Text.ToString()));
                if (en.buscarLibro())
                {
                    ModButton.Visible = true;
                    ModDropDownList1.Visible = true;
                    ModGenero.Visible = true;
                    ModLabelEditorial.Visible = true;
                    ModTextEditorial.Visible = true;
                    ModLabelPrecio.Visible = true;
                    ModTextPrecio.Visible = true;
                }
                else
                {
                    ModMsgBuscar.Visible = true;
                    ModMsgBuscar.Text = "<br> No existe este libro, intentalo de nuevo.";
                }
            }
            catch (Exception ex)
            {
                ModMsgBuscar.Visible = true;
                ModMsgBuscar.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }
        protected void BorrarLibro_Click(object sender, EventArgs e)
        {
            ElimLabelLibro.Visible = true;
            ElimISBNLibro.Visible = true;
            ElimBotonLibro.Visible = true;
            /*GridRelatosShow.Visible = false;*/
        }

        protected void EliminarLibro_Click(object sender, EventArgs e)
        {
            /*GridRelatosShow.Visible = false;*/
            ElimMsg.Visible = true;
            try
            {
                ENlibros en = new ENlibros(null, "juan@juan.com");
                en.setISBN(int.Parse(ElimISBNLibro.Text.ToString()));
                if (en.deleteLibros())
                {
                    ElimMsg.Visible = true;
                    ElimMsg.Text = "<br>Libro eliminado correctamente.";
                }
                else
                {
                    ElimMsg.Visible = true;
                    ElimMsg.Text = "<br>El libro no se ha podido eliminar.";
                }
            }
            catch (FormatException ex)
            {
                ElimMsg.Visible = true;
                ElimMsg.Text = "<br> ERROR: " + ex.Message.ToString();
            }
        }
    }
}