using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ServicioTecnicoCAD
    {
        private string constring;

        public ServicioTecnicoCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        
        public void createServicioTecnico( ServicioTecnicoEN en )
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into ServicioTecnico (fechaconsulta, consulta, fkusuario) VALUES (@fechaconsulta, @consulta, @fkusuario)", c);


                com.Parameters.AddWithValue("@fechaconsulta", en.getFechaConsulta().ToString());
                com.Parameters.AddWithValue("@consulta", en.getConsulta().ToString());
                com.Parameters.AddWithValue("@fkusuario", en.getFkUsuario().ToString());

                com.ExecuteNonQuery();

                c.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }
        }
        public void readServicioTecnico(ServicioTecnicoEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from ServicioTecnico where id=@id", c);

                com.Parameters.AddWithValue("@id", en.getId().ToString());

                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    en.setFechaConsulta(dr["fechaconsulta"].ToString());
                    en.setConsulta(dr["consulta"].ToString());
                    en.setFKusu(Int32.Parse(dr["fkusuario"].ToString()));



                }
                c.Close();



            }
            catch (Exception ex)
            {
                
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }
        }
        public void updateServicioTecnico(ServicioTecnicoEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE ServicioTecnico SET fechaconsulta=@fechaconsulta, consulta=@consulta, fkusuario=@fkusuario where id=@id", c);

                com.Parameters.AddWithValue("@fechaconsulta", en.getFechaConsulta().ToString());
                com.Parameters.AddWithValue("@consulta", en.getConsulta().ToString());
                com.Parameters.AddWithValue("@fkusuario", en.getFkUsuario().ToString());
                com.Parameters.AddWithValue("@id", en.getId().ToString());


                com.ExecuteNonQuery();

                c.Close();



            }
            catch (Exception ex)
            {

                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }
        }
        public void deleteServicioTecnico(ServicioTecnicoEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM ServicioTecnico WHERE id = " + en.getId().ToString(), c);

                com.ExecuteNonQuery();

                c.Close();
                

            }
            catch (Exception ex)
            {
                
                Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                c.Close();

            }
        }
    }
}
