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
        protected void ButtonUsuariosAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuariosAdmin.aspx");
        }
        protected void ButtonProductosAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosAdmin.aspx");
        }
        protected void ButtonPedidosAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PedidosAdmin.aspx");
        }
        protected void ButtonReclamacionesAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReclamacionesAdmin.aspx");
        }
    }
}