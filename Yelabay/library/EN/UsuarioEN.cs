using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
    public class UsuarioEN
    {
        public int id
        {
            get;
            set;
        }
        
        public string email { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string userNick { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }


        public UsuarioEN(int id, string email, string nombre, string apellidos, string contraseña,string telefono, string userNick)
        {
            this.email = email;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contraseña = contraseña;
            this.telefono = telefono;
            this.userNick = userNick;
            this.id = 0;
        }
        public UsuarioEN()
        {
            email = "";
            nombre = "";
            apellidos = "";
            contraseña = "";
            telefono = "";
            userNick = "";
            id = 0;
        }
        
        public void save()
        {
            CAD.UsuarioCAD cadUsu = new CAD.UsuarioCAD();
           // id = cadUsu.create(this);
        }

        public void createUsuario()
        {
           // UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = new UsuarioEN();
           // cad.createUsuario(en);
        }

        public void leerUsuario()
        {
            CAD.UsuarioCAD cadUsu = new CAD.UsuarioCAD();
           /* cadUsu en = (UsuarioEN)cadUsu.leerUsuario(this.id);
            if(en != null)
            {
                id = en.id;
                nombre = en.nombre;
                contraseña = en.contraseña;
                email = en.email;
                telefono = en.telefono;
                apellidos = en.apellidos;
                userNick = en.userNick;
            }*/
        }
        public bool leerPorNombreUsuario()
        {
            CAD.UsuarioCAD cadUsu = new CAD.UsuarioCAD();
            /*UsuarioEN en = cadUsu.readBy("userNick", userNick);
            if (en != null)
            {
                id = en.id;
                nombre = en.nombre;
                contraseña = en.contraseña;
                email = en.email;
                telefono = en.telefono;
                apellidos = en.apellidos;
                userNick = en.userNick;
                return true;
            }
            else
            {
                return false;
            }*/

            return false; // borrar
        }
        public void borrarUsuario()
        {
           /* CAD.UsuarioCAD cadUsu = new CAD.UsuarioCAD();
            cadUsu.borrarUsuario(this.id);*/
        }

        public void actualizarUsuario()
        {
            CAD.UsuarioCAD cadUsu = new CAD.UsuarioCAD();
            cadUsu.actualizarUsuario(this);
        }

        /*public DataSet getOrders()
        {
            //return getList(this.id); // Arreglar
        }*/
        
    }
}
