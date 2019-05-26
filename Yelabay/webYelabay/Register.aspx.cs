using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Windows.Forms;
using library.ServiceLayer;
using System.Security.Cryptography;
using System.Net.Mail;

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
                Label1.Visible = false;

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
                us.Nif = TextBoxNick.Text;
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

            if (Validator.IsSecurePass(TextBoxPassword.Text))
            {
                LabelErrorPassword.Visible = false;
                if (TextBoxPassword.Text == TextBoxRepassword.Text)
                {
                    nocoinciden.Visible = true;
                    us.Contrasenya = TextBoxPassword.Text;
                }
                else
                {
                    LabelErrorPassword.Visible = true;
                    todobien = true;
                }
            }
            else
            {
                LabelErrorPassword.Visible = true;
                todobien = true;
            }
            us.Contrasenya = TextBoxPassword.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(us.Contrasenya);
            byte[] hash = md5.ComputeHash(inputBytes);
            us.Contrasenya = BitConverter.ToString(hash).Replace("-", "");
            

            if (!Validator.noExiste("nif", TextBoxNick.Text))
            {
                nocoinciden.Visible = true;
                todobien = true;
            }
            if (!Validator.noExiste("email", TextBoxEmail.Text))
            {
                Label1.Visible = true;
                todobien = true;
            }

            if (todobien == false)
            {
                if (us != null)
                {
                    nocoinciden.Visible = true; // confimarmos que us  no es null

                    us.createUsuario();
                    Session["Usuarios"] = us;
                    CorreoConfirmacion();
                    MessageBox.Show("Bienvenido , tu cuenta ha sido creada con exito");
                    Response.Redirect("Usuario.aspx");

                }

            }
        }

        protected void CorreoConfirmacion()
        {
            string mailNuevoUser = TextBoxEmail.Text;
            string nickNuevoUser = TextBoxNick.Text;

            SmtpClient smtClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();

            try
            {
                MailAddress fromAddress = new MailAddress("yelabaytienda@gmail.com", "Tienda Yelabay");
                MailAddress toAddress = new MailAddress(mailNuevoUser, nickNuevoUser);

                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Bienvenido a Yelabay";
                message.Body = "Bienvenido " + nickNuevoUser + ", tu usuario en Yelabay ha sido creado con éxito, recuerda visitarnos para encontrar la mejor calidad y servicio en productos informáticos";
                smtClient.EnableSsl = true;
                smtClient.Credentials = new System.Net.NetworkCredential("yelabaytienda@gmail.com", "YelabayTienda-1");
                smtClient.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

    }
}