using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CategoriaCAD 
    {
        private string constring;
        public CategoriaCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createCategoria(CategoriaEN catEn)
        {
            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into Categorias (nombre) VALUES (@nombre)", c);


                com.Parameters.AddWithValue("@nombre", catEn.getNombre().ToString());
                
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

        public bool updateCategoria(CategoriaEN catEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Categorias SET nombre=@nombre where id=@id", c);

                com.Parameters.AddWithValue("@nombre", catEn.getNombre().ToString());
                com.Parameters.AddWithValue("@id", catEn.getCodCategoria().ToString());


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
        public bool deleteCategoria(CategoriaEN catEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Categorias WHERE id = " + catEn.getCodCategoria().ToString(), c);

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
        public bool readCategoria(CategoriaEN catEN)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Categorias where id=@id", c);

                com.Parameters.AddWithValue("@id", catEN.getCodCategoria().ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    catEN.setNombre(dr["nombre"].ToString());
                    
                    exito = true;


                }
                c.Close();



            }
            catch (Exception ex)
            {
                exito = false;
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }


            return exito;
        }
    }
        
    
}
