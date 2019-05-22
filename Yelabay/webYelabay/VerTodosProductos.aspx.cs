﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var categ = Request.QueryString["cat"];
            Titulo.Text = "<h1>" + categ + "</h1>";

        }
        protected void buttonRam_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("VerProducto.aspx");
        }
    }
}