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
                PopulateGridView();
            }
        }
        public void PopulateGridView()
        {
            PedidosEN en = new PedidosEN();
            DataSet da = new DataSet();
            da = en.ListarPedidos();
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridVerPedidos.DataSource = da;
                    GridVerPedidos.DataBind();
                }
                else
                {
                    GridVerPedidos.DataSource = null;
                    GridVerPedidos.DataBind();
                }
            }
        }
        protected void BotonVerPedidoDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerPedido.aspx?PedidoID=" + ((LinkButton)sender).Text);
        }
    }
}