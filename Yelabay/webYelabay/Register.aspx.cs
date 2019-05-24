using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Windows.Forms;


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
                nocoinciden.Visible = false;

            }
        }

       
        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            bool todobien = false;
            UsuarioEN us = new UsuarioEN();
            LabelUsuario.Visible = false;
            nocoinciden.Visible = false;
            if (TextBoxNick.Text == "")
            {
                LabelUsuario.Visible = true;
                todobien = true;
            }
            else
            {
                us.Nick = TextBoxNick.Text;
            }
            LabelErrorEmail.Visible = false;
            if (TextBoxEmail.Text == "")
            {
                LabelErrorEmail.Visible = true;
                todobien = true;
            }
            else
            {
                us.Email = TextBoxEmail.Text;
            }
            LabelErrorPassword.Visible = false;
            if (TextBoxPassword.Text == "")
            {
                LabelErrorPassword.Visible = true;
                todobien = true;
            }
            else
            {
                //us.Contrasenya = TextBoxPassword.Text;
            }
            LabelErrorPassworddiferente.Visible = false;
            if (TextBoxRepassword.Text == "")
            {
                LabelErrorPassworddiferente.Visible = true;
                todobien = true;
            }
            else
            {
                us.Contrasenya = TextBoxRepassword.Text;
            }

            if (TextBoxPassword.Text != TextBoxRepassword.Text)
            {
                  nocoinciden.Visible = true;
                  todobien = true;
            }
            

            if (!UsuarioEN.noexiste("Nick", TextBoxNick.Text))
            {
                nocoinciden.Visible = true;
                todobien = true;
            }
            
            if (todobien == false)
            {
                if (us != null)
                {
                    nocoinciden.Visible = true; // confimarmos que us  no es null

                    us.createUsuario();
                    Session["Usuarios"] = us;
                    MessageBox.Show("Bienvenido , tu cuenta ha sido creada con exito");
                    Response.Redirect("Usuario.aspx");

                }

            }
        }
    }
}