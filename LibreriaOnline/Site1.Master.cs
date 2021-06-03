using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaOnline {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

            //bool existe = false;
            if (Session["email"] != null && NavigationMenu.FindItem("Iniciar Sesion") != null)
            {
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("Iniciar Sesion"));
            }
            if (Session["email"] == null && NavigationMenu.FindItem("") != null)
            {
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("Recomendaciones"));
                NavigationMenu.Items.Remove(NavigationMenu.FindItem(""));
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("carrito"));
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

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e) {
            if(e.Item.ToolTip== "Cerrar Sesion")
            {
                Session.Clear();
                Response.Redirect("Home.aspx");
            }
        }
    }
}