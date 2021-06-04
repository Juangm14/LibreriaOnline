using LibreriaClases.EN;
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

            /*IDs crear libro */
            GeneroLibro.Visible = false;
            GeneroDesplegable.Visible = false;
            Titulo.Visible = false;
            TextTitulo.Visible = false;
            ISBN.Visible = false;
            TextISBN.Visible = false;
            Autores.Visible = false;
            TextAutores.Visible = false;
            Editorial.Visible = false;
            TextEditorial.Visible = false;
            Genero.Visible = false;
            TextGenero.Visible = false;
            Proveedor.Visible = false;
            TextProveedor.Visible = false;
            Precio.Visible = false;
            TextPrecio.Visible = false;
            Imagen.Visible = false;
            Boton_crearLibro.Visible = false;
            LabelCrear.Visible = false;
            formFile.Visible = false;

            /*IDs Modificar libro*/
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
            ModLabelUpdateLibro.Visible = false;
            ModLabelImagen.Visible = false;
            TextImagen.Visible = false;
            ModLabelTitulo.Visible = false;
            ModTextTitulo.Visible = false;

            /*IDs Eliminar libro */
            ElimLabelLibro.Visible = false;
            ElimISBNLibro.Visible = false;
            ElimBotonLibro.Visible = false;
            ElimMsg.Visible = false;

        }
        protected void Boton_crear(object sender, EventArgs e)
        {
            if (Session["email"] != null && (!Session["email"].ToString().Contains("@gmail.com")))
            {
                try
                {
                    ENlibros en = new ENlibros(TextISBN.Text.ToString(), TextAutores.Text.ToString(), TextTitulo.Text.ToString(), TextEditorial.Text.ToString(), TextGenero.Text.ToString(), TextProveedor.Text.ToString(), float.Parse(TextPrecio.Text.ToString()), "~/imagenesLibro/" + formFile.Text.ToString());
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

                }
                catch (FormatException ex)
                {
                    LabelCrear.Visible = true;
                    LabelCrear.Text = "<br> ERROR: " + ex.Message.ToString();
                }
                Response.Redirect("Libros.aspx");
            }
        }
        protected void NuevoLibro_Click(object sender, EventArgs e)
        {
            LabelCrear.Visible = true;
            Titulo.Visible = true;
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
            formFile.Visible = true;
            Proveedor.Visible = true;
            TextProveedor.Visible = true;
            Boton_crearLibro.Visible = true;
        }
        protected void EditarLibro_Click(object sender, EventArgs e)
        {
            ModLabelISBN.Visible = true;
            ModTextISBN.Visible = true;
            ModBuscarISBN.Visible = true;
        }

        protected void BuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                ENlibros en = new ENlibros(null,Session["Email"].ToString());
                en.setISBN(int.Parse(ModTextISBN.Text.ToString()));
                if (en.buscarLibro())
                {
                    ModLabelISBN.Visible = true;
                    ModTextISBN.Visible = true;
                    ModButton.Visible = true;
                    ModDropDownList1.Visible = true;
                    ModGenero.Visible = true;
                    ModLabelEditorial.Visible = true;
                    ModTextEditorial.Visible = true;
                    ModLabelPrecio.Visible = true;
                    ModTextPrecio.Visible = true;
                    ModLabelImagen.Visible = true;
                    TextImagen.Visible = true;
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
        }

        protected void EliminarLibro_Click(object sender, EventArgs e)
        {
            if (Session["email"] != null && (!Session["email"].ToString().Contains("@gmail.com")))
            {
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

        protected void ModificarLibro_Click(object sender, EventArgs e)
        {
            if (Session["email"] != null && (!Session["email"].ToString().Contains("@gmail.com")))
            {

                ENlibros en = new ENlibros(ModTextISBN.Text.ToString(), ModTextNewAutor.Text.ToString(), ModTextTitulo.Text.ToString(), ModTextEditorial.Text.ToString(), ModDropDownList1.Text.ToString(), "juan@juan.com", float.Parse(ModTextPrecio.Text.ToString()), "~/imagenesLibro/" + TextImagen.Text.ToString());
                try
                {
                    if (en.updateLibros())
                    {
                        ModLabelUpdateLibro.Visible = true;
                        ModLabelUpdateLibro.Text = "<br>El libro ha sido modificado correctamente.";
                    }
                    else
                    {
                        ModLabelUpdateLibro.Visible = true;
                        ModLabelUpdateLibro.Text = "<br>El libro no ha podido ser modificado, intentelo de nuevo.";
                    }
                }
                catch (FormatException ex)
                {
                    ModLabelUpdateLibro.Visible = true;
                    ModLabelUpdateLibro.Text = "<br> ERROR: " + ex.Message.ToString();
                }
            }

        }

        //Parte de Carrito, para poder añadirlo
        protected void AgregarCarrito_Command(object sender, CommandEventArgs e) {

            string ISBN = e.CommandArgument.ToString();
            ENCarrito en = new ENCarrito(ISBN, Session["email"].ToString());
            en.agregarElementoCarrito();

        }
    }
}