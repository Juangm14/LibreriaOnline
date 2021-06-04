using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) { //Vamos escondiendo o enseñando opciones del menu en base a si el usuario ha iniciado sesion o no.

            //bool existe = false;
            if (Session["email"] != null && NavigationMenu.FindItem("Iniciar Sesion") != null)
            {
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("Iniciar Sesion"));
                
            }
            if (Session["email"] == null && NavigationMenu.FindItem("") != null)
            {
                NavigationMenu.Items.Remove(NavigationMenu.FindItem(""));
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("Venta entre usuarios"));
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("Recomendaciones"));
                /* IEnumerator menuItemEnumerator = engranaje.ChildItems.GetEnumerator();
                 while (menuItemEnumerator.MoveNext())
                 {
                     if(((MenuItem)(menuItemEnumerator.Current)).ToolTip=="Cerrar Sesion")
                     {
                         existe = true;
                     }
                 }
                 if (existe == true){
                     NavigationMenu.FindItem("").ChildItems.RemoveAt(3);
                 } 
                */
            }
               
        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e) { //Si la opcion del menu que el usuario pulsa es el elemento "Cerrar Sesion" se hara Sesion.Clear() desiniciando la seasion y redirigira al usuario a la pagina Home.
            if(e.Item.ToolTip== "Cerrar Sesion")
            {
                Session.Clear();
                Response.Redirect("Home.aspx");
            }
        }
    }
}