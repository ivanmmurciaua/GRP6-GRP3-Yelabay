using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CarritoEN
    {
        //Atributos privados
        public List<ProductoEN> productos;// = new List<ProductoEN>();
        public List<int> cantidad;// { get; set; }//Numero de unidades de articulos
        public List<float> precioProdxCant;// { get; set; }//Precio de los articulos por cantidad de este
        public ProductoEN producto;
        public UsuarioEN usuario;
        private int cant;
        private float precioTotal;// { get; set; }//Suma total de todos los productos del carrito




        //Metodos publicos
        public int getCantidad() { return cant; }//Obtendremos la cantidad del producto elegido en el carrito
        public float getPreciProdxCant() { return 1; }//Obtendremos la cantidad del producto elegido en el carrito por el precio
        
        public void setCantidad(int canti) { cant = canti; }
        public ProductoEN getProducto() { return producto; }
        public UsuarioEN getUsuario() { return usuario; }

        public float getPrecioTotal()
        {
            float precioTot = 0;
            CarritoCAD cad = new CarritoCAD();
            precioTot = cad.calcularPrecioTotal(this);
            return precioTot;
        }


        public void setProducto(ProductoEN prod) { producto = prod; }
        public void setUsuario(UsuarioEN user) { usuario = user; }

        public CarritoEN()
        {
            productos = new List<ProductoEN>();
            cantidad = new List<int>();
            precioProdxCant = new List<float>();
            producto = new ProductoEN();
            usuario = new UsuarioEN();
            cant = 0;
            precioTotal = 0;
        }

        public CarritoEN(List<ProductoEN> productos, List<int> cantidad, List<float> precioProdxCant, float precioTotal)
        {
            this.productos = productos;
            this.cantidad = cantidad;
            this.precioProdxCant = precioProdxCant;
            this.precioTotal = precioTotal;
        }

        public bool anyadirProducto(int cantidad)
        {
            bool anyadido = false;

            productos.Add(producto);
            this.cantidad.Add(cantidad);
            precioProdxCant.Add(producto.getPrecio() * cantidad);
            precioTotal += producto.getPrecio() * cantidad;

            CarritoCAD cad = new CarritoCAD();
            anyadido=cad.anyadirProducto(this);

            return anyadido;
        }

        public DataSet eliminarProducto(int i)
        {
            CarritoCAD cad = new CarritoCAD();
            DataSet a = cad.eliminarProducto(this, i);
            return a;

            /*for (int i = 0; i < productos.Count(); i++)
            {
                if (producto.getCodigo() == productos[i].getCodigo())
                {
                    //productos.Remove(producto);
                    productos.RemoveAt(i);
                    cantidad.RemoveAt(i);
                    precioTotal -= precioProdxCant[i];
                    precioProdxCant.Remove(i);
                    eliminado = true;
                }
            }*/
        }

        public bool alterarCantidadProducto(ProductoEN producto, int nuevaCantidad)
        {
            bool alterado = false;

            if (nuevaCantidad > 0)
            {
                cant = nuevaCantidad;
                alterado = true;
                /*for (int i = 0; i < productos.Count(); i++)
                {
                    if (producto.getCodigo() == productos[i].getCodigo())
                    {
                        cantidad[i] = nuevaCantidad;
                        precioTotal -= precioProdxCant[i];
                        precioProdxCant[i] = nuevaCantidad * productos[i].getPrecio();
                        precioTotal += precioProdxCant[i];
                        alterado = true;
                    }
                }*/
            }

            return alterado;
        }

        public bool createCarrito()
        {
            bool creado = false;

            CarritoCAD cad = new CarritoCAD();
            if (cad.updateCarrito(this)) creado = true;

            return creado;
        }

        public bool updateCarrito()
        {
            bool actualizado = false;

            CarritoCAD cad = new CarritoCAD();
            if (cad.updateCarrito(this)) actualizado = true;

            return actualizado;
        }

        public bool deleteCarrito()
        {
            bool deleted = true;
            CarritoCAD cad = new CarritoCAD();

            if (cad.deleteCarrito(this)) deleted = true;

            return deleted;
        }

        public bool readCarrito()
        {
            bool leido = false;
            CarritoCAD cad = new CarritoCAD();

            if (cad.readCarrito(this))
            {
                leido = true;
            }

            return leido;
        }

        public void realizarCompra()
        {

        }

    }
}
