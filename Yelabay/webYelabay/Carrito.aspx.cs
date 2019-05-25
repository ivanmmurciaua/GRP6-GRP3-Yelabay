using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace webYelabay
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Filtrado por usuario actual
            /*UsuarioEN u = (UsuarioEN)Session["Usuarios"];
            string userEmail = u.getEmail();
            SqlDataCarrito.SelectCommand = "SELECT [nombreproducto], [precio], [cantidad], [precioxcantidad] FROM [Carrito] WHERE [emailusuario] LIKE '%" + userEmail + "%'";
            */

            if (!IsPostBack)
            {
                RellenarGridView();
            }

            //COOKIES USER
            /*HttpCookie userCookie;
            userCookie = Request.Cookies["UserID"];
            if (userCookie != null)
            {
                //Label1.Text = "Bienvenida otra vez, " + userCookie.Value;
                //Se rellena el carrito
            }
            else
            {
                //Label con= "Para acceder a tu carrito es necesario estar registrado como usuario";
            }*/


        }

        public void RellenarGridView()
        {
            CarritoEN carrito = new CarritoEN();
            DataSet da = new DataSet();
            da = carrito.ListarCarrito();
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridCarrito.DataSource = da;
                    GridCarrito.DataBind();
                }
                else
                {
                    GridCarrito.DataSource = null;
                    GridCarrito.DataBind();
                }
            }
        }


        /*protected void GridCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.Equals("Añadir"))
            {
                try
                {

                    String nombreProd = (GridCarrito.FooterRow.FindControl("textNombreProductoFooter") as TextBox).Text.Trim().ToString();

                    String apelli = (GridCarrito.FooterRow.FindControl("textApellidosFooter") as TextBox).Text.Trim().ToString();
                    String ni = (GridCarrito.FooterRow.FindControl("textNifFooter") as TextBox).Text.Trim().ToString();
                    String emal = (GridCarrito.FooterRow.FindControl("textEmailFooter") as TextBox).Text.Trim().ToString();
                    String contra = (GridCarrito.FooterRow.FindControl("textContraseñaFooter") as TextBox).Text.Trim().ToString();
                    String tip = (GridCarrito.FooterRow.FindControl("textDireccionFooter") as TextBox).Text.Trim().ToString();
                    String nicki = (GridCarrito.FooterRow.FindControl("textNickFooter") as TextBox).Text.Trim().ToString();
                    String telef = (GridCarrito.FooterRow.FindControl("textTelefonoFooter") as TextBox).Text.Trim().ToString();

                    CarritoEN carrito = new CarritoEN();

                    UsuarioEN usuEN = new UsuarioEN(emal, nomb, "", contra, apelli, ni, 0, nicki, telef, "estándar");


                    usuEN.createUsuario();
                    LabelMensajeExito.Text = "¡Producto añadido correctamente!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                    LabelMensajeError.Text = "¡ERROR al añadir el producto!";
                }
                RellenarGridView();







            }
        }*/



        protected void GridCarrito_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridCarrito.EditIndex = e.NewEditIndex;
            RellenarGridView();
        }

        protected void GridCarrito_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridCarrito.EditIndex = -1;
            RellenarGridView();
        }



        /*protected void GridUsuariosAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int identi = Int32.Parse(GridUsuariosAdmin.DataKeys[e.RowIndex].Value.ToString());

            String nomb = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNombre") as TextBox).Text.Trim().ToString();

            String apelli = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textApellidos") as TextBox).Text.Trim().ToString();
            String ni = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNif") as TextBox).Text.Trim().ToString();
            String emal = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textEmail") as TextBox).Text.Trim().ToString();
            String contra = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textContraseña") as TextBox).Text.Trim().ToString();
            String tip = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textDireccion") as TextBox).Text.Trim().ToString();
            String nicki = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNick") as TextBox).Text.Trim().ToString();
            String telef = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textTelefono") as TextBox).Text.Trim().ToString();

            UsuarioEN usuEN = new UsuarioEN(emal, nomb, "", contra, apelli, ni, identi, nicki, telef, "estándar");


            bool actualizado = usuEN.actualizarUsuario();
            GridUsuariosAdmin.EditIndex = -1;
            RellenarGridView();

            if (actualizado)
            {
                LabelMensajeExito.Text = "¡Usuario actualizado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al actualizar el usuario!";
            }
        }*/

        protected void GridCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridCarrito.DataKeys[e.RowIndex].Value.ToString());

            //UsuarioEN usuEN = new UsuarioEN();
            //usuEN.Id = identi;

            CarritoEN carrito = new CarritoEN();


            bool borrado = carrito.eliminarProducto();

            RellenarGridView();

            if (borrado)
            {
                //LabelMensajeExito.Text = "¡Producto borrado correctamente!";
            }
            else
            {
                //LabelMensajeError.Text = "¡ERROR al borrar el producto!";
            }

        }

        protected void Comprar_Click(object sender, EventArgs e)//De prueba
        {
            SmtpClient smtClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();

            try
            {
                MailAddress fromAddress = new MailAddress("@s", "Alias remitente");
                MailAddress toAddress = new MailAddress("@", "Alias destinatario");

                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Provando envío de mensajes";
                message.Body = "Ha realizado una compra en Yelabay";
                smtClient.EnableSsl = true;
                smtClient.Credentials = new System.Net.NetworkCredential("user", "password");
                smtClient.Send(message);
                PruebaCompra.Text = "Mensaje de confirmacion enviado";
            }
            catch (Exception ex)
            {
                PruebaCompra.Text = "No se pudo enviar mensaje de confirmación";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridView1.DeleteRow(GridView1.SelectedIndex);
            /*CarritoEN carro = new CarritoEN();
            DataSet d = carro.eliminarProducto(GridView1.SelectedIndex);
            GridView1.DataSource = d;
            GridView1.DataBind();*/
        }
    }
}