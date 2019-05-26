using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class MarcaCAD
    {
        private string constring;

        public MarcaCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            
        }

        public bool createMarca(MarcaEN marcEn)
        {
            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into Marca (nombre) VALUES (@nombre)", c);


                com.Parameters.AddWithValue("@nombre", marcEn.getNombre().ToString());

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

        public bool updateMarca(MarcaEN marcEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Marca SET nombre=@nombre where id=@id", c);

                com.Parameters.AddWithValue("@nombre", marcEn.getNombre().ToString());
                com.Parameters.AddWithValue("@id", marcEn.getIdMarca().ToString());


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

        public bool deleteMarca(MarcaEN marcEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Marca WHERE id = " + marcEn.getIdMarca().ToString(), c);

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

        public bool readMarca(MarcaEN marcEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Marca where id=@id", c);

                com.Parameters.AddWithValue("@id", marcEn.getIdMarca().ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    marcEn.setNombre(dr["nombre"].ToString());

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
