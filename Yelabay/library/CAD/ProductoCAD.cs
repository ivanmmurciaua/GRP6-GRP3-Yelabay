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
        public void crearProductos(ProductoEN en)
        {

        }

        public void borrarProductos(ProductoEN en)
        {

        }

        public void actualizarProductos(ProductoEN en)
        {

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