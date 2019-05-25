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
            if (Session["Usuarios"] == null)
            {
                buttonProfile.Visible = false;
                buttonLogout.Visible = false;
            }
        }
        protected void MenuLeft_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = MenuLeft.SelectedValue;
            switch (itemClicked)
            {
                case "home":
                    Response.Redirect("Home.aspx");
                    break;
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "componentes":
                    Response.Redirect("VerComponentes.aspx");
                    break;
                case "ordenadores":
                    Response.Redirect("VerOrdenadores.aspx");
                    break;
                case "sonido":
                    Response.Redirect("VerSmartphones.aspx");
                    break;
                case "perifericos":
                    Response.Redirect("VerPerifericos.aspx");
                    break;
                case "consolas":
                    Response.Redirect("VerConsolas.aspx");
                    break;
                default:
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
            }
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
            Session["Usuarios"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}