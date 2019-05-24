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

        public void borrarUsuario(UsuarioEN en)
        {

        }

        public void actualizarUsuario(UsuarioEN en)
        {

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
                    u.Contrasenya += dr.GetString(0);
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
                SqlCommand cm = new SqlCommand("SELECT id,nombre,apellido1,apellido2,nif,email,contrasenya,tipo FROM USUARIOS WHERE " + a + " = '" + b + "';", c);
                Console.WriteLine(cm.CommandText);
                SqlDataReader cr = cm.ExecuteReader();

                while (cr.Read())
                {
                    u = new UsuarioEN();
                    u.Id = cr.GetInt32(0);
                    u.Nombre = cr.GetString(1);
                    u.Apellidos1 = cr.GetString(2);
                    u.Nif = cr.GetString(4);
                    u.Email = cr.GetString(5);
                    u.Contrasenya = cr.GetString(6);
                    u.Direccion = cr.GetString(7);
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

        

    }
}
