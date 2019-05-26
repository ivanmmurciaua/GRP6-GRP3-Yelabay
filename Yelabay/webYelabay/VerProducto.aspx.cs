using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using library;


namespace webYelabay
{
    public partial class VerProducto : System.Web.UI.Page
    {
        private int numPro;
        private ProductoEN prod;
        protected void Page_Load(object sender, EventArgs e)
        {
            numPro = Int32.Parse(Request.QueryString["id"]);

            ProductoEN en = new ProductoEN();
            en.setCodigo(numPro);
            en.leerProductos();

            prod = en;

            //rellenar la interfaz(labels...) con EN
            LabelNombreProducto.Text = en.getNombre();
            LabelDescripcion.Text = en.getDescripcion();
            LabelPrecio.Text = en.getPrecio().ToString();
            LabelProductoID.Text = en.getCodigo().ToString();
            if (en.getStock() > 0) LabelStock.Text = en.getStock().ToString();
            else LabelStock.Text = "Sin existencias";

            if (Session["Usuarios"] == null)
            {
                butAddCarrito.Visible = false;
            }
            else
            {
                butAddCarrito.Visible = true;
            }
        }
        protected void addCarrito_Click(object sender, EventArgs e)
        {
            CarritoEN carro = new CarritoEN();

            //UsuarioEN user = new UsuarioEN("pruebaCarrito@user.com", "Andres", "Calle Preuba", "1234", "Tebar Moreno", "498765A", 22, "Andres96", "849595839");
            UsuarioEN u = (UsuarioEN)Session["Usuarios"];
            if (prod.getStock() > 0)
            {
                carro.setProducto(prod);
                carro.setCantidad(1);
                carro.setUsuario(u);
                if (carro.anyadirProducto(carro.getCantidad()))
                {
                    MessageBox.Show("Producto añadido al carrito");
                    ProductoEN pro = new ProductoEN(Int32.Parse(Request.QueryString["id"]), "", "", 0, "");
                    pro.disminuirStock(carro.getCantidad());
                }
            }
            else MessageBox.Show("Producto fuera de existencia");
            


            //Response.Redirect("Carrito.aspx?id=" + numPro.ToString());
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}