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
using library;




namespace library
{
    public class UsuarioCAD
    {
        //public abstract int createUsuario(UsuarioEN en);
        private string constring;

        public UsuarioCAD()
        {
            //string s = "data source=.\\SQLEXPRESS;Integrated Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf";
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        // constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();


        public bool createUsuario(UsuarioEN en)
        {
            bool res = false;
            UsuarioEN us = (UsuarioEN)en;
            us.Tipo = "estándar";
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand co = new SqlCommand("INSERT INTO USUARIOS (nombre,apellido1,nif,email,contrasenya,tipo, nick, telefono) VALUES ('" + 
                  us.Nombre + " ','" + us.Apellidos1 +  "','" + us.Nif + "','" + us.Email + "','" + us.Contrasenya
                  + "','" + us.Tipo + "','" + us.Nick + "','" + us.Telefono + "') ", c);
                 co.ExecuteNonQuery();
                res = true;
               
                 
            }
            catch (SqlException e)
            {
                Console.WriteLine("Opening connection failed.\nError: {0}", e.Message);
            }
            finally
            {
                c.Close();
            }
            return res;
            
        }

        public bool borrarUsuario(UsuarioEN en)
        {
            bool exito = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Usuarios WHERE id = " + en.Id.ToString(), c);


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

        public bool actualizarUsuario(UsuarioEN en)
        {
            bool exito = false;
            UsuarioEN us= (UsuarioEN)en;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                //SqlCommand com = new SqlCommand("UPDATE Usuarios SET nombre=@nombre, apellido1=@apellido1, nif=@nif, email=@email, contrasenya=@contrasenya, tipo=@tipo, nick=@nick, telefono=@telefono where id=@id", c);
                SqlCommand com = new SqlCommand("UPDATE Usuarios SET nombre= '" + us.Nombre
                    + "', telefono = '" + us.Telefono
                    + "', apellido1 = '" + us.Apellidos1
                    + "' WHERE nif = '" + us.Nif
                    + "';", c);

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

        public void leerUsuario(UsuarioEN en)
        {

        }

        public UsuarioEN buscarUsuario(string clave)
        {
            UsuarioEN u = null;
            // UsuarioEN u = new UsuarioEN();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com =new SqlCommand( "SELECT * FROM USUARIOS WHERE nif =" + clave + "' OR email = '" + clave + "' OR nick = '" + clave + "'" ,c);
                SqlDataReader dr = com.ExecuteReader();
                
                while (dr.Read())
                {
                    u = new UsuarioEN();
                    u.Id = Convert.ToInt16(dr["id"]);
                    u.Nombre += dr["nombre"].ToString();
                    u.Apellidos1 += dr["apellidos1"].ToString();
                    u.Nif += dr["nif"].ToString();
                    u.Email += dr["email"].ToString();
                    u.Contrasenya += dr["contrasenya"].ToString();
                    u.Direccion += dr["tipo"].ToString();
                    u.Nick = dr["nick"].ToString();
                    u.Telefono = dr["telefono"].ToString();
                   
                   // com.ExecuteNonQuery();
                }
                
                dr.Close();
                
        
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opening connection failed.\nError: {0}", ex.Message);
            }
            finally
            {
                c.Close();
            }

            return u;

        }

        public UsuarioEN readBy(string a, string b)
        {
            UsuarioEN u = null;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand("SELECT id,nombre,apellido1,telefono,nif,email,contrasenya,tipo,nick FROM USUARIOS WHERE " + a + " = '" + b + "';", c);
                Console.WriteLine(cm.CommandText);
                SqlDataReader cr = cm.ExecuteReader();

                while (cr.Read())
                {
                    u = new UsuarioEN();
                    u.Id = cr.GetInt32(0);
                    u.Nombre = cr.GetString(1);
                    u.Apellidos1 = cr.GetString(2);
                    u.Telefono = cr.GetString(3);
                    u.Nif = cr.GetString(4);
                    u.Email = cr.GetString(5);
                    u.Contrasenya = cr.GetString(6);
                    u.Tipo= cr.GetString(7);
                    u.Nick = cr.GetString(8);
                }
                //cm.ExecuteNonQuery();
                cr.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Users read has failed. \nError: ", e.Message);
            }
            finally
            {
                c.Close();
            }
            return u;
        }

        public DataSet ListarUsuarios(UsuarioEN en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Usuarios", c);

            da.Fill(bdvirtual, "Usuarios");

            return bdvirtual;
        }



    }
}
