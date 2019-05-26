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

        public float getPrecioTotal() { return precioTotal;}


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

        public bool eliminarProducto()
        {
            
            CarritoCAD cad = new CarritoCAD();
            return cad.eliminarProducto(this);
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
            CarritoCAD cad = new CarritoCAD();

            return cad.deleteCarrito(this);
        }

        public bool readCarrito()
        {
            CarritoCAD cad = new CarritoCAD();

            return cad.readCarrito(this);
        }

        public void realizarCompra()
        {

        }

        public DataSet ListarCarrito()
        {
            CarritoCAD cadp = new CarritoCAD();

            return cadp.ListarCarrito(this);
        }

        public void calcularPrecioTotal()
        {
            CarritoCAD cad = new CarritoCAD();
            precioTotal= cad.calcularPrecioTotal(this);
        }

        public bool incrementarProducto()
        {
            CarritoCAD cad = new CarritoCAD();
            return cad.incrementarProducto(this);
        }

    }
}
