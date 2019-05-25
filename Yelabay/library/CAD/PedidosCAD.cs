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
using System.Collections;

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
        public bool createPedido(PedidosEN en, int idUsuario)
        {

            bool exito = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();
                SqlCommand com = new SqlCommand("insert into Pedidos (fechacompra, fechaempaquetado, fechaenvio, fechaentrega, direccion, pais, preciosiniva, iva, precioconiva, fkusuario, fkagtrans, estado, ciudad) VALUES (@fechacompra, @fechaempaquetado, @fechaenvio, @fechaentrega, @direccion, @pais, @preciosiniva, @iva, @precioconiva, @fkusuario, @fkagtrans, @estado, @ciudad)", c);
                //SqlCommand com = new SqlCommand("insert into Pedidos (fechacompra, fechaempaquetado, fechaenvio, fechaentrega, direccion, pais, preciosiniva, iva, precioconiva, fkusuario, fkagtrans, estado, ciudad) VALUES (@fechacompra, @fechaempaquetado, @fechaenvio, @fechaentrega, @direccion, @pais, @preciosiniva, @iva, @precioconiva, @fkusuario, @fkagtrans, @estado, @ciudad)", c);

                com.Parameters.AddWithValue("@fechacompra", en.fechaCompra_pbl.ToString());

                com.Parameters.AddWithValue("@fechaempaquetado", en.fechaEmpaquetado_pbl.ToString());
                com.Parameters.AddWithValue("@fechaenvio", en.fechaEnvio_pbl.ToString());

                com.Parameters.AddWithValue("@fechaentrega", en.fechaEntrega_pbl.ToString());

                com.Parameters.AddWithValue("@direccion", en.direccion_pbl.ToString());

                com.Parameters.AddWithValue("@pais", en.pais_pbl.ToString());
                com.Parameters.AddWithValue("@preciosiniva", en.precioSinIVA_pbl.ToString());
                com.Parameters.AddWithValue("@iva", en.IVA_pbl.ToString());
                com.Parameters.AddWithValue("@precioconiva", en.precioConIVA_pbl.ToString());
                com.Parameters.AddWithValue("@fkusuario", idUsuario.ToString());
                com.Parameters.AddWithValue("@fkagtrans", en.agenciaDeTransporte_pbl.ToString());
                com.Parameters.AddWithValue("@estado", en.estado_pbl.ToString());
                com.Parameters.AddWithValue("@ciudad", en.ciudad_pbl.ToString());

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
        public void readPedido(PedidosEN en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Pedidos where id='" + en.id_pbl + "'", c);
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
        public bool updatePedido(PedidosEN en, int idUsu)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Productos SET fechacompra=@fechacompra, fechaempaquetado=@fechaempaquetado fechaenvio=@fechaenvio, fechaentrega=@fechaentrega, direccion=@direccion, pais=@pais, preciosiniva=@preciosiniva, iva=@iva, precioconiva=@precioconiva, fkusuario=@fkusuario, fkagtrans=@fkagtrans, estado=@estado, ciudad=@ciudad where id=@id", c);
                com.Parameters.AddWithValue("@fechacompra", en.fechaCompra_pbl.ToString());
                com.Parameters.AddWithValue("@fechaempaquetado", en.fechaEmpaquetado_pbl.ToString());
                com.Parameters.AddWithValue("@fechaenvio", en.fechaEnvio_pbl.ToString());
                com.Parameters.AddWithValue("@fechaentrega", en.fechaEntrega_pbl.ToString());
                com.Parameters.AddWithValue("@direccion", en.direccion_pbl.ToString());
                com.Parameters.AddWithValue("@pais", en.pais_pbl.ToString());
                com.Parameters.AddWithValue("@preciosiniva", en.precioSinIVA_pbl.ToString());
                com.Parameters.AddWithValue("@iva", en.IVA_pbl.ToString());
                com.Parameters.AddWithValue("@precioconiva", en.precioConIVA_pbl.ToString());
                com.Parameters.AddWithValue("@fkusuario", idUsu.ToString());
                com.Parameters.AddWithValue("@fkagtrans", en.agenciaDeTransporte_pbl.ToString());
                com.Parameters.AddWithValue("@estado", en.estado_pbl.ToString());
                com.Parameters.AddWithValue("@ciudad", en.ciudad_pbl.ToString());
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
        public bool deletePedido(PedidosEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Pedidos WHERE id = " + en.id_pbl.ToString(), c);

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
        public DataSet ListarPedidos(PedidosEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Pedidos", c);

            da.Fill(bdvirtual, "Pedidos");

            return bdvirtual;
        }
        public DataSet ListarPedidosAdmin(PedidosEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Pedidos", c);

            da.Fill(bdvirtual, "Pedidos");

            return bdvirtual;
        }
    }
}
