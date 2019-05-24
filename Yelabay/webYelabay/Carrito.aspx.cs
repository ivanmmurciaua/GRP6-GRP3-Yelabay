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
            /*CarritoEN carro = new CarritoEN();
            ProductoEN prod1 = new ProductoEN(3, "Disco Sólido Western Digital Green 3d Nand 240gb - Sata Iii - 2.5/6.35cm", "", 30);
            ProductoEN prod2 = new ProductoEN(4, "Caja Minitorre Tacens Anima Ac4", "", 10);
            ProductoEN prod3 = new ProductoEN(5, "Consola Nintendo Switch Grey + Juego Monopoly", "", 7);

            carro.anyadirProducto(prod1, 2);
            carro.anyadirProducto(prod2, 10);
            carro.anyadirProducto(prod3, 3);
            //carro.eliminarProducto(prod3);
            mostrarDatosTabla(carro);
            mostrarPrecioTotal(carro);*/

            //COOKIES USER
            HttpCookie userCookie;
            userCookie = Request.Cookies["UserID"];
            if (userCookie != null)
            {
                //Label1.Text = "Bienvenida otra vez, " + userCookie.Value;
                //Se rellena el carrito
            }
            else
            {
                //Label con= "Para acceder a tu carrito es necesario estar registrado como usuario";
            }


        }

        /*protected void mostrarPrecioTotal(CarritoEN carro)
        {
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

        protected void mostrarDatosTabla(CarritoEN carro)
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
                botonDecrementar.Click += (sendr, EventArgs) => { DecrementarProducto_Click(sendr, EventArgs, carro, i); }; ;
                celdaDecrementar.Controls.Add(botonDecrementar);
                row.Cells.Add(celdaDecrementar);

                TableCell celdaCantidad = new TableCell();
                celdaCantidad.Text = carro.cantidad[i].ToString();
                row.Cells.Add(celdaCantidad);

                TableCell celdaIncrementar = new TableCell();
                Button botonIncrementar = new Button();
                botonIncrementar.Text = "+";
                botonIncrementar.Click += (sendr, EventArgs) => { IncrementarProducto_Click(sendr, EventArgs, carro, i); }; ;
                celdaIncrementar.Controls.Add(botonIncrementar);
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


        }

        protected void DecrementarProducto_Click(object sender, EventArgs e, CarritoEN carro, int posicion)//De prueba
        {

            for (int i = 1; i < tablaCarrito.Rows.Count; i++)
            {
                if (carro.productos[posicion - 1].getNombre() == tablaCarrito.Rows[i].Cells[0].Text)
                {
                    if (carro.alterarCantidadProducto(carro.productos[posicion - 1], (carro.cantidad[posicion - 1] - 1)))
                    {
                        //int cantidadAumentar = int.Parse(tablaCarrito.Rows[i].Cells[2].Text);
                        //cantidadAumentar--;
                        tablaCarrito.Rows[i].Cells[2].Text = carro.cantidad[posicion - 1].ToString()/*cantidadAumentar.ToString();
                    }
                    else CuentaProductos.Text = "No se pudo decrementar el producto: " + carro.productos[posicion - 1].getNombre();
                }
            }
        }

        protected void IncrementarProducto_Click(object sender, EventArgs e, CarritoEN carro, int posicion)//De prueba
        {

            //TableRow rw = tablaCarrito.Rows[posicion];
            //tablaCarrito.Rows.Remove(rw);
            //carro.eliminarProducto(carro.productos[posicion-1]);
            for (int i = 1; i < tablaCarrito.Rows.Count; i++)
            {
                if (carro.productos[posicion - 1].getNombre() == tablaCarrito.Rows[i].Cells[0].Text)
                {
                    if (carro.alterarCantidadProducto(carro.productos[posicion - 1], (carro.cantidad[posicion - 1] + 1)))
                    {
                        //int cantidadAumentar= int.Parse(tablaCarrito.Rows[i].Cells[2].Text);
                        //cantidadAumentar++;
                        tablaCarrito.Rows[i].Cells[2].Text = carro.cantidad[posicion - 1].ToString()/*cantidadAumentar.ToString();
                    }
                    else CuentaProductos.Text = "No se pudo incrementar el producto: " + carro.productos[posicion - 1].getNombre();
                }
            }
        }

        protected void EliminarProducto1_Click(object sender, EventArgs e, CarritoEN carro, int posicion)
        {

            //CuentaProductos.Text = "Hola " + carro.productos[posicion-1].getNombre() + " = " + tablaCarrito.Rows[posicion-1].Cells[0].Text;
            //carro.eliminarProducto(carro.productos[posicion - 1]);
            //CuentaProductos.Text = "A ver " + carro.productos.Count.ToString();
            for (int i = 1; i < tablaCarrito.Rows.Count; i++)
            {
                if (carro.productos[posicion - 1].getNombre() == tablaCarrito.Rows[i].Cells[0].Text)
                {
                    if (carro.eliminarProducto(carro.productos[posicion - 1]))
                    {
                        TableRow row = tablaCarrito.Rows[i];
                        tablaCarrito.Rows.Remove(row);
                    }
                    else CuentaProductos.Text = "No se pudo eliminar el producto: " + carro.productos[posicion - 1].getNombre();
                }
            }
            //bool eliminado=carro.eliminarProducto(carro.productos[posicion - 1]);
            //if (eliminado) CuentaProductos.Text += " Eliminado " + carro.productos[posicion - 1].getNombre();
            //mostrarDatosTabla(carro);
            //mostrarPrecioTotal(carro);

            //carro.eliminarProducto(carro.productos[1]);
        }*/

        protected void Comprar_Click(object sender, EventArgs e)//De prueba
        {
            SmtpClient smtClient = new SmtpClient("smtp.gmail.com", 587);
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
                PruebaCompra.Text = "Mensaje de confirmacion enviado";
            }
            catch (Exception ex)
            {
                PruebaCompra.Text = "No se pudo enviar mensaje de confirmación";
            }
        }
    }
}