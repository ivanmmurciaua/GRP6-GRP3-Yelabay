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
                    decimal precioDecimal = decimal.Divide( decimal.Parse(carr.getProducto().getPrecio().ToString().Replace(',', '.')) , 100);
                    SqlCommand com = new SqlCommand("Insert Into Carrito (nombreproducto, precio, cantidad, precioxcantidad, emailusuario) VALUES ('"/* + carr.getProducto() + "','"*/ + carr.getProducto().getNombre() + "','" + precioDecimal + "','"+ carr.getCantidad() + "','" + precioDecimal * carr.getCantidad()  + "','" + carr.getUsuario().getEmail() + "')", c);
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

        public float calcularPrecioTotal(CarritoEN carrito)
        {
            float precio = 0;

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
                    t = bdvirtual.Tables["Carrito"];
                    //precio = 5;
                    for (int i=0; i<t.Rows.Count;i++)
                    {
                        
                        //DataRow fila=t.Rows[i];
                        precio++;
                        //precio += (float) fila["precioxcantidad"];
                        precio = (float) t.Rows[i][2];
                    }
                    /*
                    DataRow nuevafila = t.NewRow();
                    nuevafila[0] = cli.Usuario;
                    nuevafila[1] = cli.Contraseña;
                    nuevafila[2] = cli.Dni;
                    t.Rows.Add(nuevafila);

                    SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                    da.Update(bdvirtual, "Carrito");

                    cambiado = true;*/
                }
                catch (Exception ex) { }
                finally { c.Close(); }
            }

            return precio;
        }

        public bool readCarrito(CarritoEN carrito)
        {
            bool leido = false;

            return leido;
        }

        public DataSet eliminarProducto(CarritoEN carrito, int i)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring); SqlDataAdapter da = new
            SqlDataAdapter("select * from Carrito", c);
            da.Fill(bdvirtual, "Carrito");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["Carrito"];
            DataRow fila = t.Rows[i];
            fila.Delete();
            t.AcceptChanges();
            //t.Rows[i].Delete();
            //t.Rows[i]["usuario"] = cli.Usuario;
            //t.Rows[i]["contraseña"] = cli.Contraseña;
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "Carrito");
            return bdvirtual;
        }

    }
}
