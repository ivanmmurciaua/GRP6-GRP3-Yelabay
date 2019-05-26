using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using library;

namespace webYelabay
{
    public partial class CrearReclamacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBoxNumPedido_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            UsuarioEN en = new UsuarioEN();
            en = (UsuarioEN)Session["Usuarios"];
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("yyyy/MM/dd");
            ReclamacionesEN rec = new ReclamacionesEN(en,TextBoxMotivo.Text,fecha,false);

            if(rec.createReclamacion()) MessageBox.Show("Tu reclamacion ha sido enviada con exito!");
            TextBoxMotivo.Text = "";

        }
    }
}