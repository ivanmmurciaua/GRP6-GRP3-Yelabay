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
    public partial class Pedido : System.Web.UI.Page
    {
        private string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Request.QueryString["PedidoId"];
            }
            PedidosEN en = new PedidosEN();
            en.id_pbl = Int32.Parse(id);
            en.readPedido();
            LabelDireccion.Text = en.direccion_pbl.ToString();
            LabelCiudad.Text = en.ciudad_pbl.ToString();
            LabelPais.Text = en.pais_pbl.ToString();
            LabelPrecioSinIva.Text = en.precioSinIVA_pbl.ToString();
            LabelIVA.Text = en.IVA_pbl.ToString();
            LabelPrecioConIVA.Text = en.precioConIVA_pbl.ToString();
            LabelFechaCompra.Text = en.fechaCompra_pbl.ToString();
            LabelFechaEmpaquetado.Text = en.fechaEmpaquetado_pbl.ToString();
            LabelFechaEnvio.Text = en.fechaEnvio_pbl.ToString();
            LabelFechaEntrega.Text = en.fechaEntrega_pbl.ToString();
        }
    }
}