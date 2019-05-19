using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            carro.anyadirProducto(prod2, 10);
            carro.anyadirProducto(prod3, 3);
            //carro.eliminarProducto(prod3);

            mostrarTabla(carro);


        }

        protected void mostrarTabla(CarritoEN carro)
        {
            for (int i = 0; i < carro.productos.Count; i++)
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
                botonEliminar.Font.Bold = true;
                botonEliminar.ForeColor = System.Drawing.Color.Red;
                botonEliminar.Attributes.Add("runat", "server");
                botonEliminar.Click += (sendr, EventArgs) => { EliminarProducto1_Click(sendr, EventArgs, carro, i); }; ;
                //botonEliminar.Click += new EventHandler(this.EliminarProducto1_Click);
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
            TableCell celdaVacia4 = new TableCell();
            celdaVacia4.Text = "";
            ultimaFila.Cells.Add(celdaVacia4);

            
            TableCell precioTotal = new TableCell();
            precioTotal.Text = carro.getPrecioTotal().ToString();
            ultimaFila.Cells.Add(precioTotal);
            TableCell celdaPrecio = new TableCell();
            celdaPrecio.Text = "€ en total";
            ultimaFila.Cells.Add(celdaPrecio);

            tablaCarrito.Rows.Add(ultimaFila);
        }


        protected void eliminarFila(int fila)
        {
            TableRow rw = tablaCarrito.Rows[fila];
            tablaCarrito.Rows.Remove(rw);
        }

        protected void EliminarProducto1_Click(object sender, EventArgs e, CarritoEN carro, int posicion)//De prueba
        {

            TableRow rw = tablaCarrito.Rows[posicion];
            tablaCarrito.Rows.Remove(rw);
            carro.eliminarProducto(carro.productos[posicion]);
            //UpdatePanel1.Update();
            //mostrarTabla(carro);
            
            //carro.eliminarProducto(carro.productos[1]);
        }

        protected void Comprar_Click(object sender, EventArgs e)//De prueba
        {
            SmtpClient smtClient = new SmtpClient("smtp.gmail.com",587);
            MailMessage message = new MailMessage();

            try
            {
                MailAddress fromAddress = new MailAddress("@s", "Alias remitente");
                MailAddress toAddress = new MailAddress("@", "Alias destinatario");

                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Provando envío de mensajes";
                message.Body = "Ha realizado una compra en Yelabay";
                smtClient.EnableSsl = true;
                smtClient.Credentials = new System.Net.NetworkCredential("user", "password");
                smtClient.Send(message);
                PruebaCompra.Text ="Mensaje de confirmacion enviado";
            }
            catch(Exception ex)
            {
                PruebaCompra.Text = "No se pudo enviar mensaje de confirmación";
            }
        }
    }
}