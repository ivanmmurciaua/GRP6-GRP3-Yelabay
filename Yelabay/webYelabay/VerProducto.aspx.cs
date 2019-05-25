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
            LabelStock.Text = en.getStock().ToString();





        }
        protected void addCarrito_Click(object sender, EventArgs e)
        {

            //ProductoEN en = new ProductoEN();
            //en.setCodigo(numPro);
            //en.leerProductos();

           /* CarritoEN carrito = new CarritoEN();
            carrito.setProducto(prod);
            carrito.setCantidad(1);

            LabelNombreProducto.Text = "A VER:" + carrito.getProducto().getNombre();
            LabelDescripcion.Text = "A VER:" + carrito.getProducto().getDescripcion();
            LabelPrecio.Text = "A VER:" + carrito.getProducto().getPrecio().ToString();
            LabelProductoID.Text = "A VER:" + carrito.getProducto().getCodigo().ToString();
            LabelStock.Text = "A VER:" + carrito.getProducto().getStock().ToString();

            UsuarioEN user = new UsuarioEN("pruebaCarrito@user.com", "Andres", "Calle Preuba", "1234", "Tebar Moreno", "498765A", 22, "Andres96", "849595839");

            carrito.setUsuario(user);
            if (carrito.anyadirProducto( carrito.getCantidad())) Anyadido.Text = "Anyadido!!!!";*/
            CarritoEN carro = new CarritoEN();
            ProductoEN prod1 = new ProductoEN();
            prod1.setCodigo(prod.getCodigo());
            prod1.setNombre(prod.getNombre());
            prod1.setPrecio(prod.getPrecio());
            prod1.setStock(prod.getStock());
            prod1.setDescripcion(prod.getDescripcion());

            UsuarioEN user = new UsuarioEN("pruebaCarrito@user.com", "Andres", "Calle Preuba", "1234", "Tebar Moreno", "498765A", 22, "Andres96", "849595839");

            carro.setProducto(prod1);
            carro.setCantidad(1);
            carro.setUsuario(user);
            if (carro.anyadirProducto( carro.getCantidad())) Anyadido.Text = "Anyadido!!!!";


            //Response.Redirect("Carrito.aspx?id=" + numPro.ToString());
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}