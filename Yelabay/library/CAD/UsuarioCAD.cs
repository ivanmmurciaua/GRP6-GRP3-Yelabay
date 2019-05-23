using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using library;
using System.Data.Common;
using System.Data.SqlTypes;

namespace library.CAD
{
    public class UsuarioCAD
    {
        
        public UsuarioCAD() //Constructor
        {

        }

        public void createUsuario(UsuarioEN en)
        {
           /* int id = -1;
            UsuarioEN user = (UsuarioEN)user;
            try
            {
                SqlCommand c = new SqlCommand("INSERT INTO USERS (nombre, apellido1, email, contrasenya,telefono,userNick) VALUES ('" +
                   user.nombre + "','" + user.apellidos + "','" + user.email + "','" +
                    user.contraseña + "', '" + user.telefono + "' ,'" + user.userNick + "'); SELECT SCOPE_IDENTITY() ", sc);
                id = Convert.ToInt32(c.ExecuteScalar());
                return id;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Opening connection failed.\nError: {0}", e.Message);
            }
            finally
            {
                sc.Close();
            }
            return id;*/
        }

        public void borrarUsuario(UsuarioEN en)
        {

        }

        public void actualizarUsuario(UsuarioEN en)
        {

        }

        public void leerUsuario(int id)
        {/*
            EN.UsuarioEN u = new UsuarioEN();
            try
            {
                SqlCommand c = new SqlCommand("SELECT userNick, nombre, apellido1, email, contrasenya, telefono FROM USERS WHERE Id = " + id + ";", sc);
                SqlDataReader cr = c.ExecuteReader();

                while (cr.Read())
                {
                    u.userNick = cr.GetString(0);
                    u.nombre = cr.GetString(1);
                    u.apellidos = cr.GetString(2);
                    u.email = cr.GetString(3);
                    u.contraseña = cr.GetString(4);
                    u.telefono = cr.GetString(5);
                }
                cr.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Users read has failed. \nError: ", e.Message);
            }
            finally
            {
                sc.Close();
            }
            return u;*/
        }
    }
    
}
