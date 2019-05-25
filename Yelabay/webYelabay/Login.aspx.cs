using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Windows.Forms;
using System.Security.Cryptography;

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
        
     UsuarioEN u = new UsuarioEN();
     u.Nif = txtUsername.Text;

            if (u.login())
            {
                
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
                byte[] hash = md5.ComputeHash(inputBytes);
                txtPassword.Text = BitConverter.ToString(hash).Replace("-", "");


                if (u.Contrasenya == txtPassword.Text)
                {

                    Session["Usuarios"] = u;
                    //Session["user"] = u.Nif;
                    //Session["password"] = u.Contrasenya;
                    //Response.Write("bienvenido");
                    //Response.Write(Session["user"]);


                    Response.Redirect("VerTodosProductos.aspx");
                }
                else
                {
                    LabelError.Visible = true;
                }
            }
            else
            {
                LabelError.Visible = true;
            }
        }
    }
}