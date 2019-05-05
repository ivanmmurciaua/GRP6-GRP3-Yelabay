using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LabelUsuario.Visible = false;
                LabelErrorEmail.Visible = false;
                LabelErrorPassword.Visible = false;
                LabelErrorPassworddiferente.Visible = false;

            }
        }
    }
}