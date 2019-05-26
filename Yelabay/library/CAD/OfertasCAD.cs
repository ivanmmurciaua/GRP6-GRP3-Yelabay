using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class OfertasCAD
    {

        private string constring;

        public OfertasCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            
        }

        public bool createOferta(OfertasEN oferEn)
        {

            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into Ofertas (diainicio, diafin, porcentaje, diferencia) VALUES (@diainicio, @diafin, @porcentaje, @diferencia)", c);


                com.Parameters.AddWithValue("@diainicio", oferEn.getFechaInicio().ToString());
                com.Parameters.AddWithValue("@diafin", oferEn.getFechaFin().ToString());
                com.Parameters.AddWithValue("@porcentaje", oferEn.getDescuentoPorcen().ToString());
                com.Parameters.AddWithValue("@diferencia", oferEn.getDiferencia().ToString());

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

        public bool updateOferta(OfertasEN oferEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Ofertas SET diainicio=@diainicio, diafin=@diafin, porcentaje=@porcentaje, diferencia=@diferencia where id=@id", c);

                com.Parameters.AddWithValue("@id", oferEn.getCodigoOferta().ToString());
                com.Parameters.AddWithValue("@diainicio", oferEn.getFechaInicio().ToString());
                com.Parameters.AddWithValue("@diafin", oferEn.getFechaFin().ToString());
                com.Parameters.AddWithValue("@porcentaje", oferEn.getDescuentoPorcen().ToString());
                com.Parameters.AddWithValue("@diferencia", oferEn.getDiferencia().ToString());
                

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

        public bool deleteOferta(OfertasEN oferEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Ofertas WHERE id = " + oferEn.getCodigoOferta().ToString(), c);

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

        public bool readOferta(OfertasEN oferEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Ofertas where id=@id", c);

                com.Parameters.AddWithValue("@id", oferEn.getCodigoOferta().ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    oferEn.setFechaInicio(dr["diainicio"].ToString());
                    oferEn.setFechaFin(dr["diafin"].ToString());
                    oferEn.setDescuentoPorcen(Int32.Parse(dr["diafin"].ToString()));
                    oferEn.setDiferencia((float)Convert.ToSingle(dr["precioenvio"].ToString()));
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
