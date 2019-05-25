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

            if (!readCarrito(carr))
            {
                SqlConnection c = new SqlConnection(constring);
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand("Insert Into Carrito (precio, cantidad, precioxcantidad) VALUES ('"/* + carr.getProducto() + "','" + carr.getUsuario() + "','" */ +  carr.getProducto().getPrecio() + "','"+ 3 + "','" + carr.getProducto().getPrecio() * 3  + "')", c);
                    com.ExecuteNonQuery();
                    
                    anyadidio = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemas en la conexion Sql");
                }
                finally
                {
                    c.Close();
                }
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
            bool deleted = true;

            return deleted;
        }

        public int calcularPrecioTotal(CarritoEN carrito)
        {
            int precio = 0;

            CarritoEN carr = carrito;

            if (!readCarrito(carr))
            {
                DataSet bdvirtual = new DataSet();
                SqlConnection c = new SqlConnection(constring);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from Carrito", c);
                    da.Fill(bdvirtual, "Carrito");
                    DataTable t = new DataTable();
                    t = bdvirtual.Tables["cliente"];
                    /*
                    DataRow nuevafila = t.NewRow();
                    nuevafila[0] = cli.Usuario;
                    nuevafila[1] = cli.Contraseña;
                    nuevafila[2] = cli.Dni;
                    t.Rows.Add(nuevafila);

                    SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                    da.Update(bdvirtual, "Carrito");*/

                    //cambiado = true;
                }
                catch (Exception ex) {  }
                finally { c.Close(); }
            }

            return precio;
        }

        public bool readCarrito(CarritoEN carrito)
        {
            bool leido = false;

            return leido;
        }

    }
}
