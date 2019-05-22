using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ProductoEN
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private int stock { get; set; }
        private float precio { get; set; }

        public ProductoEN(int codigo, string nombre, string descripcion, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
        }

        public ProductoEN()
        {
            codigo = 0;
            nombre = "";
            descripcion = "";
            stock = 0;
            precio = 0;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public int getStock()
        {
            return stock;
        }

        public float getPrecio()
        {
            return precio;
        }


        public void crearProductos()
        {
            ProductoCAD cad = new ProductoCAD();
            ProductoEN en = new ProductoEN();
            cad.crearProductos(en);

        }

        public void borrarProductos()
        {
            ProductoCAD cad = new ProductoCAD();
            ProductoEN en = new ProductoEN();
            cad.borrarProductos(en);
        }

        public void actualizarProductos()
        {
            ProductoCAD cad = new ProductoCAD();
            ProductoEN en = new ProductoEN();
            cad.actualizarProductos(en);
        }
        public void leerProductos()
        {
            ProductoCAD cad = new ProductoCAD();
            ProductoEN en = new ProductoEN();
            cad.leerProductos(en);
        }
    }
}
