using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;
using System.Windows.Forms;
using System.Net.Mail;

namespace webYelabay
{
    public partial class ConfirmacionPedido : System.Web.UI.Page
    {
        private float TotalCarrito;
        private float TotalSinIVA;
        protected void Page_Load(object sender, EventArgs e)
        {
            TotalCarrito = (float) Convert.ToSingle(Request.QueryString["Total"].ToString());
            TotalSinIVA = TotalCarrito /(float) 1.21;
            if (!IsPostBack)
            {
                
                IniciarLlenadoDropDown();
                LabelEuro.Visible = false;
                LabelPrecioEnvio.Text = 0.ToString();
                LabelPrecioEnvio.Visible = false;
                LabelPrecioTotalSinIVA.Text =TotalSinIVA.ToString();
                LabelPrecioTotal.Text = TotalCarrito.ToString();
            }
        }

        private void IniciarLlenadoDropDown()
        {
            DropListAgTrans.DataSource = Consultar();
            DropListAgTrans.DataTextField = "nombre";
            DropListAgTrans.DataValueField = "id";
            DropListAgTrans.DataBind();
            DropListAgTrans.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void DropListAgTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropListAgTrans.SelectedValue);

            AgenciaTEN agtEn = new AgenciaTEN();
            agtEn.codigo_pbl = id;
            agtEn.leerAgenciaT();
            LabelPais.Text = agtEn.pais_pbl;
            double auxdouble = TotalSinIVA + agtEn.precioEnvio_pbl;
            double AUX=Math.Truncate(auxdouble);
            float auxSinIVA = (float)AUX;
            float auxConIVA = TotalCarrito + agtEn.precioEnvio_pbl;
            //rellenar con precios carrito
            LabelPrecioEnvio.Text = agtEn.precioEnvio_pbl.ToString();
            LabelPrecioTotalSinIVA.Text = auxSinIVA.ToString();
            LabelPrecioTotal.Text = auxConIVA.ToString();
            
            if (id != 0)
            {
                LabelEuro.Visible = true;
                
                LabelPrecioEnvio.Visible = true;
            }
            else
            {
                LabelEuro.Visible = false;
               
                LabelPrecioEnvio.Visible = false;
            }


        }

        public DataSet Consultar()
        {
            AgenciaTEN agtEN = new AgenciaTEN();
            return agtEN.ListarAgenciaT();
        }

        protected void ButtonConfirmarPedido_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(DropListAgTrans.SelectedValue) != 0) && TextBoxDireccion.Text != "" && TextBoxCiudad.Text != "" && TextBoxPais.Text != "")
            {
                DateTime thisDay = DateTime.Today;
                CarritoEN carrito = new CarritoEN();//Crea carrito
                UsuarioEN u = (UsuarioEN)Session["Usuarios"];//Guardamos usuario actual
                carrito.setUsuario(u);//En Carrito

                int id = Convert.ToInt32(DropListAgTrans.SelectedValue);
                PedidosEN pedEn = new PedidosEN();
                pedEn.direccion_pbl = TextBoxDireccion.Text.ToString();
                pedEn.ciudad_pbl = TextBoxCiudad.Text.ToString();
                pedEn.pais_pbl = TextBoxPais.Text.ToString();
                pedEn.agenciaDeTransporte_pbl = id.ToString();
                int idUsu = ((UsuarioEN)Session["Usuarios"]).Id;
                pedEn.precioSinIVA_pbl = Convert.ToSingle(LabelPrecioTotalSinIVA.Text.ToString());
                pedEn.precioConIVA_pbl = Convert.ToSingle(LabelPrecioTotal.Text.ToString());
                pedEn.fechaCompra_pbl = thisDay.ToString("d");
                pedEn.estado_pbl = "Comprado";
                pedEn.id_pbl = 21;
                pedEn.createPedidoNuevo(idUsu);
                carrito.deleteCarrito();
                MessageBox.Show("Pedido realizado. Gracias por su compra");
                CorreoConfirmacion();


                Response.Redirect("VerTodosProductos.aspx");
                
            }
            else
            {
                LabelMensajeError.Text = "Error al rellenar los datos. Intentelo de nuevo";
            }


        }

        protected void CorreoConfirmacion()
        {
            UsuarioEN u = (UsuarioEN)Session["Usuarios"];
            string mailNuevoUser = u.getEmail();
            string nickNuevoUser = u.getNombre();
            DateTime thisDay = DateTime.Today;

            SmtpClient smtClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();

            try
            {
                MailAddress fromAddress = new MailAddress("yelabaytienda@gmail.com", "Tienda Yelabay");
                MailAddress toAddress = new MailAddress(mailNuevoUser, nickNuevoUser);

                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Gracias por su compra";
                message.Body = "Gracias por confiar en nosotros " + nickNuevoUser + ", ha realizado una compra hoy día: " + thisDay.ToString("d") + " con Dirección: " + TextBoxDireccion.Text.ToString() + " y un coste de " + LabelPrecioTotal.Text.ToString() + "€";
                smtClient.EnableSsl = true;
                smtClient.Credentials = new System.Net.NetworkCredential("yelabaytienda@gmail.com", "YelabayTienda-1");
                smtClient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
            }
        }
    }
}