using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webYelabay
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EliminarProducto1_Click(object sender, EventArgs e)//De prueba
        {
            TableRow rw = tablaCarrito.Rows[1];
            tablaCarrito.Rows.Remove(rw);
        }
        protected void EliminarProducto2_Click(object sender, EventArgs e)
        {
            /*TableRow rw = tablaCarrito.Rows[2];
            tablaCarrito.Rows.Remove(rw);*/
        }

        protected void EliminarProducto3_Click(object sender, EventArgs e)
        {
            /*TableRow rw = tablaCarrito.Rows[3];
            tablaCarrito.Rows.Remove(rw);*/
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*TableCell cll = tablaCarrito.Rows[1].Cells[1];
            TableCell cllPrecio = tablaCarrito.Rows[1].Cells[2];
            int nuevoValor = int.Parse(cllPrecio.Text) * int.Parse(DropDownList1.Text);
            cllPrecio.Text = nuevoValor.ToString();*/
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*TableCell cll = tablaCarrito.Rows[2].Cells[1];
            TableCell cllPrecio = tablaCarrito.Rows[2].Cells[2];
            int nuevoValor = int.Parse(cllPrecio.Text) * int.Parse(DropDownList2.Text);
            cllPrecio.Text = nuevoValor.ToString();*/
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*TableCell cll = tablaCarrito.Rows[2].Cells[1];
            TableCell cllPrecio = tablaCarrito.Rows[2].Cells[2];
            int nuevoValor = int.Parse(cllPrecio.Text) * int.Parse(DropDownList2.Text);
            cllPrecio.Text = nuevoValor.ToString();*/
        }
    }
}