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
           
            if(Session["Usuarios"]==null){
                buttonProfile.Visible = false;
                buttonLogout.Visible = false;
                buttonLogin.Visible = true;
                buttonCarrito.Visible = false;
            }
            else
            {
                buttonProfile.Visible = true;
                buttonLogout.Visible = true;
                buttonLogin.Visible = false;
                buttonCarrito.Visible = true;
            }
            

        }
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = Menu1.SelectedValue;
            switch (itemClicked)
            {
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "componentes":
                    Response.Redirect("VerComponentes.aspx");
                    break;
            }
        }
        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = Menu2.SelectedValue;
            switch (itemClicked)
            {
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "ordenadores":
                    Response.Redirect("VerOrdenadores.aspx");
                    break;
            }
        }
        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = Menu3.SelectedValue;
            switch (itemClicked)
            {
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "consolas":
                    Response.Redirect("VerConsolas.aspx");
                    break;
            }
        }
        protected void Menu4_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = Menu4.SelectedValue;
            switch (itemClicked)
            {
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "perifericos":
                    Response.Redirect("VerPerifericos.aspx");
                    break;
            }
        }
        protected void Menu5_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = Menu5.SelectedValue;
            switch (itemClicked)
            {
                case "producto":
                    Response.Redirect("VerTodosProductos.aspx");
                    break;
                case "smartphones":
                    Response.Redirect("VerSmartphones.aspx");
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