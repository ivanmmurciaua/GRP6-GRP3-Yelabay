using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace library
{
    class ProductoCAD
    {
        private string constring;
        public ProductoCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool crearProductos(ProductoEN en, int idMarca, int idOferta, int idCategoria)
        {
            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                //String nom = (en.getNombre()).ToString();
                c.Open();
                SqlCommand com = new SqlCommand("insert into Productos (nombre, precio, stock, fkmarca, fkcategoria, descripcion, foto) VALUES (@nombre, @precio, @stock, @fkmarca, @fkcategoria, @descripcion, @foto)", c);
                //SqlCommand com = new SqlCommand("insert into Productos (nombre, precio, stock, descripcion, foto) VALUES (@nombre, @precio, @stock, @descripcion, @foto)", c);

                com.Parameters.AddWithValue("@nombre", en.getNombre().ToString());

                com.Parameters.AddWithValue("@precio", (en.getPrecio()).ToString());
                com.Parameters.AddWithValue("@stock", (en.getStock()).ToString());

                com.Parameters.AddWithValue("@fkmarca", idMarca.ToString());
                //com.Parameters.AddWithValue("@fkoferta", idOferta);
                com.Parameters.AddWithValue("@fkcategoria", idCategoria.ToString());

                com.Parameters.AddWithValue("@descripcion", en.getDescripcion().ToString());
                com.Parameters.AddWithValue("@foto", en.getImagen().ToString());

                com.ExecuteNonQuery();




                c.Close();
                exito = true;


            }
            catch (Exception ex)
            {
                exito = false;
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }
            return exito;

        }

        public bool borrarProductos(ProductoEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Productos WHERE id = " + en.getCodigo(), c);


                com.ExecuteNonQuery();




                c.Close();
                exito = true;


            }
            catch (Exception ex)
            {
                exito = false;
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }


            return exito;
        }

        public bool actualizarProductos(ProductoEN en, int idMarca, int idOferta, int idCategoria)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Productos SET nombre=@nombre, precio=@precio, stock=@stock, fkmarca=@fkmarca, fkcategoria=@fkcategoria, descripcion=@descripcion, foto=@foto where id=@id", c);
                com.Parameters.AddWithValue("@nombre", en.getNombre().ToString());
                com.Parameters.AddWithValue("@precio", en.getPrecio().ToString());
                com.Parameters.AddWithValue("@stock", en.getStock().ToString());
                com.Parameters.AddWithValue("@fkmarca", idMarca.ToString());
                //com.Parameters.AddWithValue("@fkoferta", idOferta.ToString());
                com.Parameters.AddWithValue("@fkcategoria", idCategoria.ToString());
                com.Parameters.AddWithValue("@descripcion", en.getDescripcion().ToString());
                com.Parameters.AddWithValue("@foto", en.getImagen().ToString());
                com.Parameters.AddWithValue("@id", en.getCodigo().ToString());
                com.ExecuteNonQuery();




                c.Close();
                exito = true;


            }
            catch (Exception ex)
            {
                exito = false;
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }


            return exito;

        }
        public void leerProductos(ProductoEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Productos where id='" + en.getCodigo() + "'", c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    en.setNombre(dr["nombre"].ToString());

                    en.setPrecio(Convert.ToSingle(dr["precio"].ToString()));
                    en.setStock(Int32.Parse(dr["stock"].ToString()));
                    en.setImagen(dr["foto"].ToString());
                    en.setDescripcion(dr["descripcion"].ToString());

                }
                dr.Close();
                c.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);

            }
        }
    }
}