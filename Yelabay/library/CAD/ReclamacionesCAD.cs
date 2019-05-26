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
    class ReclamacionesCAD
    {
        private string constring;
        public ReclamacionesCAD()
        {
            //se establece la conexion con la BD
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createReclamacion(ReclamacionesEN reclamacion)
        {
            bool creado = false;

            ReclamacionesEN rec = reclamacion;
            int idusu = rec.GetUsuarioReclama().getId();      

            if (!readReclamacion(rec))
            {
                SqlConnection c = new SqlConnection(constring);
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand("Insert Into Reclamaciones (reclamacion, fechareclamacion,fkusuario) VALUES ('" + rec.getReclamacion() + "','"+ rec.getFecha() +"','" + idusu + "')", c);

                    com.ExecuteNonQuery();
                    creado = true;
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


            return creado;
        }

        public bool updateReclamacion(ReclamacionesEN reclamacion)
        {
            bool updated = false;

            return updated;
        }

        public bool readReclamacion(ReclamacionesEN reclamacion)
        {
            bool leida = false;
            ReclamacionesEN rec = reclamacion;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Reclamaciones where reclamacion='" + rec.getReclamacion() + "' and fechareclamacion='" + rec.getFecha() + "' and fkusuario='" + rec.GetUsuarioReclama() + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                leida = dr.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas en la conexion Sql");
            }
            finally
            {
                c.Close();
            }


            return leida;
        }

        public bool borrarReclamacion(ReclamacionesEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Reclamacion WHERE id = " + en.Id , c);


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

        public DataSet ListarReclamaciones(ReclamacionesEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Reclamaciones", c);

            da.Fill(bdvirtual, "Reclamaciones");

            return bdvirtual;
        }

    }
}
