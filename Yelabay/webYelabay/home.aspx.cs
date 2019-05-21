using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkCatalogo_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = LinkCatalogo.SelectedValue;

            Response.Redirect("VerTodosProductos.aspx");
        }
        protected void LinkRegistro_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = LinkRegistro.SelectedValue;

            Response.Redirect("Register.aspx");
        }
        protected void LinkLogin_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = LinkLogin.SelectedValue;

            Response.Redirect("Login.aspx");
        }
    }
}