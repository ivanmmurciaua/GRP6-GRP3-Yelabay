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
        public string Email { get; set; }
        public string Apellidos1 { get; set; }
        public string Apellidos2 { get; set; }
        public string Nif { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contraseña { get; set; }
        public int Id { get; set; }

        public UsuarioEN(string Email, string Nombre, string Direccion, string Contraseña, string Apellidos1, string Apellidos2, string Nif, int Id)
        {
            this.Email = Email;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Contraseña = Contraseña;
            this.Apellidos1 = Apellidos1;
            this.Apellidos2 = Apellidos2;
            this.Nif = Nif;
            this.Id = Id;
        }
        public UsuarioEN()
        {
            Email = "";
            Nombre = "";
            Direccion = "";
            Contraseña = "";
            Apellidos1 = "";
            Apellidos2 = "";
            Nif = "";
            Id = 0;
        }
        public string getEmail()
        {
            return Email;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public string getContraseña()
        {
            return Contraseña;
        }

        public void hacerConsultaServicioTecnico()
        {

        }

        public void createUsuario()
        {
            UsuarioCAD cad = new UsuarioCAD();
            
            cad.createUsuario(this);
        }

        public void borrarUsuario()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = new UsuarioEN();
            cad.borrarUsuario(en);
        }

        public void actualizarUsuario()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = new UsuarioEN();
            cad.actualizarUsuario(en);
        }

        public void leerUsuario()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = new UsuarioEN();
            cad.leerUsuario(en);
        }
        public bool login()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = cad.readBy("nif",Nif);
            if (en != null)
            {
                Email = en.Email;
                Nombre = en.Nombre;
                Direccion = en.Direccion;
                Contraseña = en.Contraseña;
                Apellidos1 = en.Apellidos1;
                Apellidos2 = en.Apellidos2;
                Nif = en.Nif;
                Id = en.Id;
                return true;
            }
            else
            {
                return false;
            }

        }

        public UsuarioEN buscarUsuario(string clave)
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en= cad.buscarUsuario(clave);
            
            return en;

        }

        public static bool noexiste(string field, string s)
        {
            UsuarioCAD cad = new UsuarioCAD();
           /* if (cad.readBy(field, s) == null)
            {
                return true;
            }
            else
            {*/
                return true;
            //}
        }
    }
}
