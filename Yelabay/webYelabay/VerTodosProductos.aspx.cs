using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace webYelabay
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
        protected void Datalist_ItemCommand(object source, DataListCommandEventArgs e)
        {
            
            Response.Redirect("VerProducto.aspx?id=" + e.CommandArgument.ToString());
            
        }
        */
        protected void ImagenProduc_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("VerProducto.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}