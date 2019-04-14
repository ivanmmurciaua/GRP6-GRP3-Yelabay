using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class UsuarioEN
    {
        private string email { get; set; }
        private string nombre { get; set; }
        private string direccion { get; set; }
        private string contraseña { get; set; }

        public UsuarioEN(string email, string nombre, string direccion, string contraseña)
        {
            this.email = email;
            this.nombre = nombre;
            this.direccion = direccion;
            this.contraseña = contraseña;
        }
        public UsuarioEN()
        {
            email = "";
            nombre = "";
            direccion = "";
            contraseña = "";
        }
        public string getEmail()
        {
            return email;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public string getContraseña()
        {
            return contraseña;
        }

        public void hacerConsultaServicioTecnico()
        {

        }

        public void createUsuario()
        {
            UsuarioCAD cad = new UsuarioCAD();
            UsuarioEN en = new UsuarioEN();
            cad.createUsuario(en);
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
    }
}
