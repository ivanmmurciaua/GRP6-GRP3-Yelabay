using System;
using System.Collections.Generic;
using System.Linq;
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
            CarritoEN carro = new CarritoEN();
            ProductoEN prod1 = new ProductoEN(3, "Disco Sólido Western Digital Green 3d Nand 240gb - Sata Iii - 2.5/6.35cm",  "", 30);
            ProductoEN prod2 = new ProductoEN(4, "Caja Minitorre Tacens Anima Ac4", "", 10);
            ProductoEN prod3 = new ProductoEN(5, "Consola Nintendo Switch Grey + Juego Monopoly", "", 7);

            carro.anyadirProducto(prod1, 2);
            carro.anyadirProducto(prod2, 1);
            carro.anyadirProducto(prod3, 3);


            for (int i=0; i< carro.productos.Count; i++)
            {
                TableRow row = new TableRow();

                TableCell celdaNombre = new TableCell();
                celdaNombre.Text = carro.productos[i].getNombre();
                row.Cells.Add(celdaNombre);

                TableCell celdaDecrementar = new TableCell();
                Button botonDecrementar = new Button();
                botonDecrementar.Text = "-";
                //botonDecrementar.OnClick=carro.alterarCantidadProducto(carro.productos[i], (carro.cantidad[i] - 1));
                celdaDecrementar.Controls.Add(botonDecrementar);
                row.Cells.Add(celdaDecrementar);

                TableCell celdaCantidad = new TableCell();
                celdaCantidad.Text = carro.cantidad[i].ToString();
                row.Cells.Add(celdaCantidad);

                TableCell celdaIncrementar = new TableCell();
                Button botonINcrementar = new Button();
                botonINcrementar.Text = "+";
                celdaIncrementar.Controls.Add(botonINcrementar);
                row.Cells.Add(celdaIncrementar);

                TableCell precioProdxCant = new TableCell();
                precioProdxCant.Text = carro.precioProdxCant[i].ToString();
                row.Cells.Add(precioProdxCant);

                TableCell celdaEliminar = new TableCell();
                Button botonEliminar = new Button();
                botonEliminar.Text = "X";
                botonEliminar.OnClick = "EliminarProducto1_Click";
                celdaEliminar.Controls.Add(botonEliminar);
                row.Cells.Add(celdaEliminar);

                tablaCarrito.Rows.Add(row);
            }

            TableRow ultimaFila = new TableRow();

            TableCell celdaVacia = new TableCell();
            celdaVacia.Text = "";
            ultimaFila.Cells.Add(celdaVacia);
            TableCell celdaVacia2 = new TableCell();
            celdaVacia2.Text = "";
            ultimaFila.Cells.Add(celdaVacia2);
            TableCell celdaVacia3 = new TableCell();
            celdaVacia3.Text = "";
            ultimaFila.Cells.Add(celdaVacia3);
            TableCell celdaPrecio = new TableCell();
            celdaPrecio.Text = "Precio Total:";
            ultimaFila.Cells.Add(celdaPrecio);
            TableCell precioTotal= new TableCell();
            precioTotal.Text = carro.getPrecioTotal().ToString();
            ultimaFila.Cells.Add(precioTotal);

            tablaCarrito.Rows.Add(ultimaFila);


        }

        protected void EliminarProducto1_Click(object sender, EventArgs e)//De prueba
        {
            TableRow rw = tablaCarrito.Rows[1];
            tablaCarrito.Rows.Remove(rw);
        }

        protected void Comprar_Click(object sender, EventArgs e)//De prueba
        {
            PruebaCompra.Text = "Comprado";
        }
    }
}