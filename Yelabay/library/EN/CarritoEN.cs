using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CarritoEN
    {
        //Atributos privados
        private List<ProductoEN> productos;// = new List<ProductoEN>();
        private List<int> cantidad;// { get; set; }//Numero de unidades de articulos
        private List<float> precioProdxCant;// { get; set; }//Precio de los articulos por cantidad de este
        private float precioTotal;// { get; set; }//Suma total de todos los productos del carrito



        //Metodos publicos
        public int getCantidad() { return cantidad; }//Obtendremos la cantidad del producto elegido en el carrito
        public float getPreciProdxCant() { return precioProdxCant; }//Obtendremos la cantidad del producto elegido en el carrito por el precio
        public float getPrecioTotal() { return precioTotal; }


        public CarritoEN()
        {
            productos = new List<ProductoEN>();
            cantidad = new List<int>();
            precioProdxCant = new List<float>();
            precioTotal = 0;
        }

        public CarritoEN(List<ProductoEN> productos, List<int> cantidad, List<float> precioProdxCant, float precioTotal)
        {
            this.productos = productos;
            this.cantidad = cantidad;
            this.precioProdxCant = precioProdxCant;
            this.precioTotal = precioTotal;
        }
        
        public bool anyadirProducto(ProductoEN producto, int cantidad)
        {
            bool anyadido = false;
            
            //Lo de abajo quiza va en CarritoCAD
            productos.Add(producto);
            cantidad.Add(cantidad);
            precioProdxCant.Add(producto.getPrecio()*cantidad);
            precioTotal += producto.getPrecio() * cantidad;
            anyadido = true;

            return anyadido;
        }

        public bool eliminarProducto(ProductoEN producto)
        {
            bool eliminado;

            for(int i=0; i < productos.Count(); i++)
            {
                if (producto.codigo==productos[i].codigo)
                {
                    productos.Remove(i);
                    cantidad.Remove(i);
                    precioTotal -= precioProdxCant[i];
                    precioProdxCant.Remove(i);
                    eliminado = true;
                }
            }

            return eliminado;
        }

        public bool alterarCantidadProducto(ProductoEN producto, int nuevaCantidad)
        {
            bool alterado=false;

            for (int i = 0; i < productos.Count(); i++)
            {
                if (producto.codigo == productos[i].codigo)
                { 
                    cantidad[i]=nuevaCantidad;
                    precioProdxCant[i] = nuevaCantidad * productos[i].precio;
                    precioTotal -= precioProdxCant[i];
                    alterado=true;
                }
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
            bool actualizado=false;

            CarritoCAD cad = new CarritoCAD();
            if (cad.updateCarrito(this)) actualizado = true;

            return actualizado;
        }

        public bool deleteCarrito()
        {
            bool deleted;
            CarritoCAD cad = new CarritoCAD();

            if (cad.deleteCarrito(this)) deleted = true;

            return deleted;
        }
        
        public bool readCarrito()
        {
            bool leido = falso;
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
