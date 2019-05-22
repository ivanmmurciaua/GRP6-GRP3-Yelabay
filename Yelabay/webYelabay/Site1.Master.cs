using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void MenuLeft_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = MenuLeft.SelectedValue;
            switch (itemClicked)
            {
                case "home":
                    Response.Redirect("Home.aspx");
                    break;
                default:
                    Response.Redirect("VerTodosProductos.aspx?cat="+itemClicked);
                    break;
            }
        }
        protected void MenuContact_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (MenuContact.SelectedValue == "contact")
                Response.Redirect("Contact.aspx");
        }
        protected void buttonHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
        protected void buttonCarrito_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }
        protected void buttonLogin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void buttonProfile_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Usuario.aspx");
        }
        protected void buttonLogout_Click(object sender, ImageClickEventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}