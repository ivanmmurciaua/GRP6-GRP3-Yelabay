using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace library
{
    public class CarritoCAD
    {
        private string constring;
        public CarritoCAD()
        {
            //se establece la conexion con la BD
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createCarrito(CarritoEN carrito)
        {
            bool creado = false;

            return creado;
        }

        public bool anyadirProducto(CarritoEN carrito)
        {
            bool anyadidio = false;

            CarritoEN carr = carrito;

                SqlConnection c = new SqlConnection(constring);
                try
                {
                    c.Open();
                    //int precio = int.Parse(carr.getProducto().getPrecio().ToString().Replace(',', '.'));
                    int precio = (int)carr.getProducto().getPrecio();
                    decimal precioDecimal = (decimal) precio;
                    SqlCommand com = new SqlCommand("Insert Into Carrito (nombreproducto, precio, cantidad, precioxcantidad, emailusuario) VALUES ('"/* + carr.getProducto() + "','"*/ + carr.getProducto().getNombre() + "','" + precioDecimal + "','"+ carr.getCantidad() + "','" + precioDecimal * carr.getCantidad()  + "','" + carr.getUsuario().getEmail() + "')", c);
                    com.ExecuteNonQuery();
                    
                    anyadidio = true;
                }
                catch (Exception ex)
                {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                Console.WriteLine("Problemas en la conexion Sql");
                }
                finally
                {
                    c.Close();
                }

            return anyadidio;
        }


        public bool updateCarrito(CarritoEN carrito)
        {
            bool actualizado = false;

            

            return actualizado;
        }

        public bool deleteCarrito(CarritoEN carrito)
        {
            bool deleted = false;
            string email = carrito.getUsuario().getEmail();

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Carrito WHERE emailusuario LIKE '%" + email + "%'", c);
                com.ExecuteNonQuery();
                c.Close();
                deleted = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();
            }

            return deleted;
        }

        public float calcularPrecioTotal(CarritoEN carrito)
        {
            float precio = 0;
            string email = carrito.getUsuario().getEmail();

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Carrito WHERE emailusuario LIKE '%" + email + "%'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    precio += float.Parse (dr["precioxcantidad"].ToString());
                }
                c.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();
            }


            return precio;
        }

        public bool readCarrito(CarritoEN carrito)
        {
            bool leido = false;
            string email = carrito.getUsuario().getEmail();
            string nombreProd = carrito.getProducto().getNombre();

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Carrito WHERE emailusuario LIKE '%" + email + "%'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read() && !leido)
                {
                    leido = (nombreProd == dr["nombreproducto"].ToString());
                }
                c.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();
            }

            return leido;
        }

        public bool eliminarProducto(CarritoEN carrito)
        {
            bool eliminado = false;
            string email = carrito.getUsuario().getEmail();
            string nombreProd = carrito.getProducto().getNombre();

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Carrito WHERE emailusuario LIKE '%" +email + "%' AND nombreproducto LIKE '%"+ nombreProd+"%'", c);


                com.ExecuteNonQuery();
                c.Close();
                eliminado= true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();
            }

            return eliminado;
        }

        public DataSet ListarCarrito(CarritoEN en)
        {
            string email = en.getUsuario().getEmail();
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Carrito WHERE emailusuario LIKE '%" + email + "%'", c);

            da.Fill(bdvirtual, "Carrito");

            return bdvirtual;
        }

        public bool incrementarProducto(CarritoEN carrito)
        {
            bool incrementado=false;
            int cantidad=0;
            decimal precio = 0;
            string email = carrito.getUsuario().getEmail();
            string nombreProd = carrito.getProducto().getNombre();

            //Obtenemos cantidad actual
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Carrito WHERE emailusuario LIKE '%" + email + "%'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if(nombreProd == dr["nombreproducto"].ToString())
                    {
                        cantidad = int.Parse(dr["cantidad"].ToString());
                        precio = decimal.ToInt32((decimal) dr["precio"]);
                    }
                }
                c.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();
            }
            cantidad++;
            decimal precioxcantidad = precio * cantidad; /*precio * cantidad;*/
            //Actualizamos la cantidad
            SqlConnection co = new SqlConnection(constring);
            try
            {
                co.Open();
                SqlCommand com = new SqlCommand("UPDATE Carrito SET cantidad = "+ cantidad + ", precioxcantidad = " + precioxcantidad + " WHERE emailusuario LIKE '%" + email + "%' AND nombreproducto LIKE '%" + nombreProd + "%'", co);


                com.ExecuteNonQuery();
                co.Close();
                incrementado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                co.Close();
            }

            return incrementado;
        }

    }
}
