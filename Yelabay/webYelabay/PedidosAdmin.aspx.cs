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
    public partial class PedidosAdmin : System.Web.UI.Page
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
            PedidosEN pedEN = new PedidosEN();
            DataSet da = new DataSet();
            da = pedEN.ListarPedidos();
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridPedidosAdmin.DataSource = da;
                    GridPedidosAdmin.DataBind();
                }
                else
                {
                    GridPedidosAdmin.DataSource = da;
                    GridPedidosAdmin.DataBind();

                }

            }
        }

        protected void GridPedidosAdmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.Equals("Añadir"))
            {
                try
                {

                    String feccom = (GridPedidosAdmin.FooterRow.FindControl("textFechaCompraFooter") as TextBox).Text.Trim().ToString();
                    String fecemp = (GridPedidosAdmin.FooterRow.FindControl("textFechaEmpaquetadoFooter") as TextBox).Text.Trim().ToString();
                    String fecenv = (GridPedidosAdmin.FooterRow.FindControl("textFechaEnvioFooter") as TextBox).Text.Trim().ToString();
                    String fecent = (GridPedidosAdmin.FooterRow.FindControl("textFechaEntregaFooter") as TextBox).Text.Trim().ToString();
                    String direcc = (GridPedidosAdmin.FooterRow.FindControl("textDireccionFooter") as TextBox).Text.Trim().ToString();
                    String pais = (GridPedidosAdmin.FooterRow.FindControl("textPaisFooter") as TextBox).Text.Trim().ToString();
                    String ciudad = (GridPedidosAdmin.FooterRow.FindControl("textCiudadFooter") as TextBox).Text.Trim().ToString();
                    String estado = (GridPedidosAdmin.FooterRow.FindControl("textEstadoFooter") as TextBox).Text.Trim().ToString();

                    float precsiniv = (float)Convert.ToSingle((GridPedidosAdmin.FooterRow.FindControl("textPrecioSinIvaFooter") as TextBox).Text);
                    float precconiv = (float)Convert.ToSingle((GridPedidosAdmin.FooterRow.FindControl("textPrecioConIvaFooter") as TextBox).Text);
                    int iv = Int32.Parse((GridPedidosAdmin.FooterRow.FindControl("textIvaFooter") as TextBox).Text.Trim().ToString());
                    int fkusu = Int32.Parse((GridPedidosAdmin.FooterRow.FindControl("textUsuarioFooter") as TextBox).Text.Trim().ToString());
                    String fktrans = (GridPedidosAdmin.FooterRow.FindControl("textATFooter") as TextBox).Text.Trim().ToString();



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


        protected void GridPedidosAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridPedidosAdmin.EditIndex = e.NewEditIndex;
            RellenarGridView();
        }

        protected void GridPedidosAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridPedidosAdmin.EditIndex = -1;
            RellenarGridView();
        }


        protected void GridPedidosAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int identi = Int32.Parse(GridPedidosAdmin.DataKeys[e.RowIndex].Value.ToString());
            String feccom = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textFechaCompra") as TextBox).Text.Trim().ToString();
            String fecemp = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textFechaEmpaquetado") as TextBox).Text.Trim().ToString();
            String fecenv = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textFechaEnvio") as TextBox).Text.Trim().ToString();
            String fecent = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textFechaEntrega") as TextBox).Text.Trim().ToString();
            String direcc = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textDireccion") as TextBox).Text.Trim().ToString();
            String pais = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textPais") as TextBox).Text.Trim().ToString();
            String ciudad = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textCiudad") as TextBox).Text.Trim().ToString();
            String estado = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textEstado") as TextBox).Text.Trim().ToString();

            float precsiniv = (float)Convert.ToSingle((GridPedidosAdmin.Rows[e.RowIndex].FindControl("textPrecioSinIva") as TextBox).Text);
            float precconiv = (float)Convert.ToSingle((GridPedidosAdmin.Rows[e.RowIndex].FindControl("textPrecioConIva") as TextBox).Text);
            int iv = Int32.Parse((GridPedidosAdmin.Rows[e.RowIndex].FindControl("textIva") as TextBox).Text.Trim().ToString());
            int fkusu = Int32.Parse((GridPedidosAdmin.Rows[e.RowIndex].FindControl("textUsuario") as TextBox).Text.Trim().ToString());
            String fktrans = (GridPedidosAdmin.Rows[e.RowIndex].FindControl("textAT") as TextBox).Text.Trim().ToString();

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
            GridPedidosAdmin.EditIndex = -1;
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

        protected void GridPedidosAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridPedidosAdmin.DataKeys[e.RowIndex].Value.ToString());

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