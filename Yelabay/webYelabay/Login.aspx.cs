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
            Response.Redirect("Register.aspx");
        }



        protected void Button1_Click1(object sender, EventArgs e)
        {

           /* UsuarioEN us = new UsuarioEN();
            UsuarioEN en =us.buscarUsuario(txtUsername.Text);
            

            if (en != null)
            {


                if (en.Contraseña == txtPassword.Text)
                {
                    Session["Usuarios"] = en;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    MessageBox.Show("pringao");
                    LabelError.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("tonto");
                LabelError.Visible = true;
            }*/






        
             UsuarioEN u = new UsuarioEN();
             u.Nif = txtUsername.Text;

             if (u.login() && u.Contrasenya == txtPassword.Text)
             {
                 Session["user"] = u;
                 Response.Redirect("Home.aspx");
             }
             LabelError.Visible = true;

        }
    }
}