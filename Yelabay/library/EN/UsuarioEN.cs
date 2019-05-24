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
        public string Nif { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contrasenya { get; set; }
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; internal set; }

        public UsuarioEN(string Email, string Nombre, string Direccion, string Contrasenya, string Apellidos1, string Nif, int Id, string Nick, int Telefono)
        {
            this.Email = Email;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Contrasenya = Contrasenya;
            this.Apellidos1 = Apellidos1;
            this.Nif = Nif;
            this.Id = Id;
            this.Nick = Nick;
        }
        public UsuarioEN()
        {
            Email = "";
            Nombre = "";
            Direccion = "";
            Contrasenya = "";
            Apellidos1 = "";
            Nif = "";
            Nick = "";
            Id = 0;
            Telefono = "";
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
            return Contrasenya;
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
                Contrasenya = en.Contrasenya;
                Apellidos1 = en.Apellidos1;
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
