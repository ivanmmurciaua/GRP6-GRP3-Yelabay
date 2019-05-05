using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LabelError.Visible = false;
            }
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Register.aspx");
        }
    }
}