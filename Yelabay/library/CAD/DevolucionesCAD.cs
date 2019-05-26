using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class DevolucionesCAD
    {
        private string constring;
        public DevolucionesCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createDevolucion(DevolucionesEN devEn)
        {
            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into Devoluciones (motivo, fechadevolucion, fkpedido) VALUES (@motivo, @fechadevolucion, @fkpedido)", c);


                com.Parameters.AddWithValue("@motivo", devEn.getMotivo().ToString());
                com.Parameters.AddWithValue("@fechadevolucion", devEn.getFechaDevolucion().ToString());
                com.Parameters.AddWithValue("@fkpedido", devEn.getCodigoPedido().ToString());

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

        public bool updateDevolucion(DevolucionesEN devEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Devoluciones SET motivo=@motivo, fechadevolucion=@fechadevolucion, fkpedido=@fkpedido where id=@id", c);

                com.Parameters.AddWithValue("@motivo", devEn.getMotivo().ToString());
                com.Parameters.AddWithValue("@fechadevolucion", devEn.getFechaDevolucion().ToString());
                com.Parameters.AddWithValue("@fkpedido", devEn.getCodigoPedido().ToString());
                com.Parameters.AddWithValue("@id", devEn.getId().ToString());


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

        public bool deleteDevolucion(DevolucionesEN devEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Devoluciones WHERE id = " + devEn.getId().ToString(), c);

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

        public bool readDevolucion(DevolucionesEN devEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Devoluciones where id=@id", c);

                com.Parameters.AddWithValue("@id", devEn.getId().ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    devEn.setMotivo(dr["motivo"].ToString());
                    devEn.setFechaDevolucion(dr["fechadevolucion"].ToString());
                    devEn.setCodigoPedido(Int32.Parse(dr["fkpedido"].ToString()));

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
