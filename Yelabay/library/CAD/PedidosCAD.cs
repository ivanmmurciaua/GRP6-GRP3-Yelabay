using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace library
{
    public class PedidosCAD
    {
        private string constring;
        public PedidosCAD()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        ~PedidosCAD()
        {
        }
        public void createPedido(PedidosEN en)
        {
        }
        public void readPedido(PedidosEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Pedidos where id='" + en.getId() + "'", c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read() == true)
                {
                    /*
                    en.usuario.nif = dr["nif"].ToString();
                    en.nombreUsuario = dr["nombre"].ToString();
                    en.edadUsuario = Convert.ToInt32(dr["edad"].ToString());
                    */

                    //Creo que deberia ser solo la clave
                    //en.usuario=dr["fkusuario"].ToString();
                    en.fechaCompra_pbl = dr["fechacompra"].ToString();
                    en.fechaEmpaquetado_pbl = dr["fechaempaquetado"].ToString();
                    en.fechaEnvio_pbl = dr["fechaenvio"].ToString();
                    en.fechaEntrega_pbl = dr["fechaentrega"].ToString();
                    en.direccion_pbl = dr["direccion"].ToString();
                    en.ciudad_pbl = dr["ciudad"].ToString();
                    en.pais_pbl = dr["pais"].ToString();
                    en.precioSinIVA_pbl = Convert.ToSingle(dr["preciosiniva"].ToString());
                    en.IVA_pbl = Convert.ToInt32(dr["iva"].ToString());
                    en.precioConIVA_pbl = Convert.ToSingle(dr["precioconiva"].ToString());
                    //en.agenciaDeTransporte_pbl = Convert.ToInt32(dr["fkagtrans"].ToString());
                    //en.numUsuario_pbl = Convert.ToInt32(dr["fkusuario"].ToString());
                }

                dr.Close();
                c.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: { 0} ", ex.Message);
            }
        }
        public void updatePedido(PedidosEN en)
        {
        }
        public void deletePedido( PedidosEN en )
        {
        }
        public DataSet ListarPedidos(PedidosEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Pedidos", c);

            da.Fill(bdvirtual, "Pedidos");

            return bdvirtual;
        }
    }
}
