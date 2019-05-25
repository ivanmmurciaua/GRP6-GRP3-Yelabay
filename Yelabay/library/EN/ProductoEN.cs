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
        private string imagen { get; set; }



        public ProductoEN(int codigo, string nombre, string descripcion, int stock, string imagen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
            this.imagen = imagen;
        }

        public ProductoEN()
        {
            codigo = 0;
            nombre = "";
            descripcion = "";
            stock = 0;
            precio = 0;
            imagen = "";
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

        public string getImagen()
        {
            return imagen;
        }








        public void setCodigo(int cod2)
        {
            codigo = cod2;
        }

        public void setNombre(string nomb2)
        {
            nombre = nomb2;
        }

        public void setDescripcion(string descripcion2)
        {
            descripcion = descripcion2;
        }

        public void setStock(int stock2)
        {
            stock = stock2;
        }

        public void setPrecio(float precio2)
        {
            precio = precio2;
        }

        public void setImagen(string imagen2)
        {
            imagen = imagen2;
        }


        public bool crearProductos(int idMarca, int idOferta, int idCategoria)
        {
            ProductoCAD cad = new ProductoCAD();

            return cad.crearProductos(this, idMarca, idOferta, idCategoria);

        }

        public bool borrarProductos()
        {
            ProductoCAD cad = new ProductoCAD();

            return cad.borrarProductos(this);
        }

        public bool actualizarProductos(int idMarca, int idOferta, int idCategoria)
        {
            ProductoCAD cad = new ProductoCAD();

            return cad.actualizarProductos(this, idMarca, idOferta, idCategoria);
        }
        public void leerProductos()
        {
            ProductoCAD cad = new ProductoCAD();

            cad.leerProductos(this);
        }
    }
}