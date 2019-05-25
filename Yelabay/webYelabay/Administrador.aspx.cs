using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MenuLef_MenuItemClick(object sender, MenuEventArgs e)
        {
            string itemClicked = MenuLef.SelectedValue;
            switch (itemClicked)
            {
                case "usuarios":
                    Response.Redirect("UsuariosAdmin.aspx");
                    break;
                case "articulos":
                    Response.Redirect("ProductosAdmin.aspx");
                    break;
                default:
                    Response.Redirect("Administrador.aspx");
                    break;
            }
        }
    }
}