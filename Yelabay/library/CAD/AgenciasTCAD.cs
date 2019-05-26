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
    class AgenciasTCAD
    {

        private string constring;

        public AgenciasTCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool crearAgenciaT(AgenciaTEN en)
        {
            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into AgenciasT (nombre, pais, precioenvio) VALUES (@nombre, @pais, @precioenvio)", c);


                com.Parameters.AddWithValue("@nombre", en.nombre_pbl.ToString());

                com.Parameters.AddWithValue("@pais", en.pais_pbl.ToString());
                com.Parameters.AddWithValue("@precioenvio", en.precioEnvio_pbl.ToString());

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

        public bool actualizarAgenciaT(AgenciaTEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE AgenciasT SET nombre=@nombre, pais=@pais, precioenvio=@precioenvio where id=@id", c);

                com.Parameters.AddWithValue("@nombre", en.nombre_pbl.ToString());
                com.Parameters.AddWithValue("@pais", en.pais_pbl.ToString());
                com.Parameters.AddWithValue("@precioenvio", en.precioEnvio_pbl.ToString());
                com.Parameters.AddWithValue("@id", en.codigo_pbl.ToString());

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
        public bool borrarAgenciaT(AgenciaTEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM AgenciasT WHERE id = " + en.codigo_pbl.ToString(), c);

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

        public bool leerAgenciaT(AgenciaTEN agtEn)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from AgenciasT where id=@id", c);

                com.Parameters.AddWithValue("@id", agtEn.codigo_pbl.ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    agtEn.nombre_pbl = dr["nombre"].ToString();
                    agtEn.pais_pbl = dr["pais"].ToString();
                    agtEn.precioEnvio_pbl = (float)Convert.ToSingle(dr["precioenvio"].ToString());
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


        public DataSet ListarAgenciaT(AgenciaTEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from AgenciasT", c);

            da.Fill(bdvirtual, "AgenciasT");

            return bdvirtual;
        }


    }
}
