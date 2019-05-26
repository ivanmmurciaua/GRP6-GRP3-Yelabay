using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;

namespace webYelabay
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RellenarGridView();
            }
        }

        public void RellenarGridView()
        {
            UsuarioEN usu = new UsuarioEN();
            usu = (UsuarioEN)Session["Usuarios"];
            PedidosEN pedEN = new PedidosEN();
            DataSet da = new DataSet();
            da = pedEN.ListarPedidoUsu(usu.getId());
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridPedidosUser.DataSource = da;
                    GridPedidosUser.DataBind();
                }
                else
                {
                    GridPedidosUser.DataSource = da;
                    GridPedidosUser.DataBind();

                }

            }
        }

        protected void GridPedidosUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.Equals("Añadir"))
            {
                try
                {

                    String feccom = (GridPedidosUser.FooterRow.FindControl("textFechaCompraFooter") as TextBox).Text.Trim().ToString();
                    String fecemp = (GridPedidosUser.FooterRow.FindControl("textFechaEmpaquetadoFooter") as TextBox).Text.Trim().ToString();
                    String fecenv = (GridPedidosUser.FooterRow.FindControl("textFechaEnvioFooter") as TextBox).Text.Trim().ToString();
                    String fecent = (GridPedidosUser.FooterRow.FindControl("textFechaEntregaFooter") as TextBox).Text.Trim().ToString();
                    String direcc = (GridPedidosUser.FooterRow.FindControl("textDireccionFooter") as TextBox).Text.Trim().ToString();
                    String pais = (GridPedidosUser.FooterRow.FindControl("textPaisFooter") as TextBox).Text.Trim().ToString();
                    String ciudad = (GridPedidosUser.FooterRow.FindControl("textCiudadFooter") as TextBox).Text.Trim().ToString();
                    String estado = (GridPedidosUser.FooterRow.FindControl("textEstadoFooter") as TextBox).Text.Trim().ToString();

                    float precsiniv = (float)Convert.ToSingle((GridPedidosUser.FooterRow.FindControl("textPrecioSinIvaFooter") as TextBox).Text);
                    float precconiv = (float)Convert.ToSingle((GridPedidosUser.FooterRow.FindControl("textPrecioConIvaFooter") as TextBox).Text);
                    int iv = Int32.Parse((GridPedidosUser.FooterRow.FindControl("textIvaFooter") as TextBox).Text.Trim().ToString());
                    int fkusu = Int32.Parse((GridPedidosUser.FooterRow.FindControl("textUsuarioFooter") as TextBox).Text.Trim().ToString());
                    String fktrans = (GridPedidosUser.FooterRow.FindControl("textATFooter") as TextBox).Text.Trim().ToString();



                    PedidosEN pedEN = new PedidosEN();

                    pedEN.fechaCompra_pbl = feccom;
                    pedEN.fechaEmpaquetado_pbl = fecemp;
                    pedEN.fechaEntrega_pbl = fecent;
                    pedEN.fechaEnvio_pbl = fecenv;
                    pedEN.direccion_pbl = direcc;
                    pedEN.pais_pbl = pais;
                    pedEN.precioSinIVA_pbl = precsiniv;
                    pedEN.precioConIVA_pbl = precconiv;
                    pedEN.IVA_pbl = iv;
                    pedEN.estado_pbl = estado;
                    pedEN.ciudad_pbl = ciudad;
                    pedEN.agenciaDeTransporte_pbl = fktrans;



                    pedEN.createPedido(fkusu);

                    LabelMensajeExito.Text = "¡Producto añadido correctamente!";
                }
                catch (Exception ex)
                {

                    Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                    LabelMensajeError.Text = "¡ERROR al añadir el producto!";
                }





            }
        }


        protected void GridPedidosUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridPedidosUser.EditIndex = e.NewEditIndex;
            RellenarGridView();
        }

        protected void GridPedidosUser_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridPedidosUser.EditIndex = -1;
            RellenarGridView();
        }


        protected void GridPedidosUser_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int identi = Int32.Parse(GridPedidosUser.DataKeys[e.RowIndex].Value.ToString());
            String feccom = (GridPedidosUser.Rows[e.RowIndex].FindControl("textFechaCompra") as TextBox).Text.Trim().ToString();
            String fecemp = (GridPedidosUser.Rows[e.RowIndex].FindControl("textFechaEmpaquetado") as TextBox).Text.Trim().ToString();
            String fecenv = (GridPedidosUser.Rows[e.RowIndex].FindControl("textFechaEnvio") as TextBox).Text.Trim().ToString();
            String fecent = (GridPedidosUser.Rows[e.RowIndex].FindControl("textFechaEntrega") as TextBox).Text.Trim().ToString();
            String direcc = (GridPedidosUser.Rows[e.RowIndex].FindControl("textDireccion") as TextBox).Text.Trim().ToString();
            String pais = (GridPedidosUser.Rows[e.RowIndex].FindControl("textPais") as TextBox).Text.Trim().ToString();
            String ciudad = (GridPedidosUser.Rows[e.RowIndex].FindControl("textCiudad") as TextBox).Text.Trim().ToString();
            String estado = (GridPedidosUser.Rows[e.RowIndex].FindControl("textEstado") as TextBox).Text.Trim().ToString();

            float precsiniv = (float)Convert.ToSingle((GridPedidosUser.Rows[e.RowIndex].FindControl("textPrecioSinIva") as TextBox).Text);
            float precconiv = (float)Convert.ToSingle((GridPedidosUser.Rows[e.RowIndex].FindControl("textPrecioConIva") as TextBox).Text);
            int iv = Int32.Parse((GridPedidosUser.Rows[e.RowIndex].FindControl("textIva") as TextBox).Text.Trim().ToString());
            int fkusu = Int32.Parse((GridPedidosUser.Rows[e.RowIndex].FindControl("textUsuario") as TextBox).Text.Trim().ToString());
            String fktrans = (GridPedidosUser.Rows[e.RowIndex].FindControl("textAT") as TextBox).Text.Trim().ToString();

            PedidosEN pedEN = new PedidosEN();

            pedEN.fechaCompra_pbl = feccom;
            pedEN.fechaEmpaquetado_pbl = fecemp;
            pedEN.fechaEntrega_pbl = fecent;
            pedEN.fechaEnvio_pbl = fecenv;
            pedEN.direccion_pbl = direcc;
            pedEN.pais_pbl = pais;
            pedEN.precioSinIVA_pbl = precsiniv;
            pedEN.precioConIVA_pbl = precconiv;
            pedEN.IVA_pbl = iv;
            pedEN.estado_pbl = estado;
            pedEN.ciudad_pbl = ciudad;
            pedEN.agenciaDeTransporte_pbl = fktrans;







            bool actualizado = pedEN.updatePedido(fkusu);
            GridPedidosUser.EditIndex = -1;
            RellenarGridView();

            if (actualizado)
            {
                LabelMensajeExito.Text = "¡Producto actualizado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al actualizar el producto!";
            }
        }

        protected void GridPedidosUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridPedidosUser.DataKeys[e.RowIndex].Value.ToString());

            PedidosEN pedEN = new PedidosEN();
            pedEN.id_pbl = identi;

            bool borrado = pedEN.deletePedido();

            RellenarGridView();

            if (borrado)
            {
                LabelMensajeExito.Text = "¡Producto borrado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al borrar el producto!";
            }

        }

        protected void BotonVerPedidoDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerPedido.aspx?PedidoID=" + ((LinkButton)sender).Text);
        }


    }
}