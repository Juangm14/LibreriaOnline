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
        }
        protected void Boton_crear(object sender, EventArgs e)
        {
            try
            {
                ENlibros en = new ENlibros(TextISBN.Text, TextAutores.Text, TextTitulo.Text, TextEditorial.Text, TextGenero.Text, TextProveedor.Text, float.Parse(TextPrecio.Text), "");
                if (en.createLibros())
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
            LabelTitulo.Visible = false;
        }
        protected void BorrarLibro_Click(object sender, EventArgs e)
        {

        }
    }
}