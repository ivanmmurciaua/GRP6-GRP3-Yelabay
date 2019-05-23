using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace webYelabay
{
    public partial class VerProducto : System.Web.UI.Page
    {
        private int numPro;
        protected void Page_Load(object sender, EventArgs e)
        {
            numPro = Int32.Parse(Request.QueryString["id"]);

            ProductoEN en = new ProductoEN();
            en.setCodigo(numPro);
            en.leerProductos();

            //rellenar la interfaz(labels...) con EN
            LabelNombreProducto.Text = en.getNombre();
            LabelDescripcion.Text = en.getDescripcion();
            LabelPrecio.Text = en.getPrecio().ToString();
            LabelProductoID.Text = en.getCodigo().ToString();
            LabelStock.Text = en.getStock().ToString();





        }
        protected void addCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=" + numPro.ToString());
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}