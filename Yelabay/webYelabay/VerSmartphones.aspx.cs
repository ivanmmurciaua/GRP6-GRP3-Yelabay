using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class VerSmartphones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImagenProduc_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("VerProducto.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}