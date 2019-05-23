using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ReclamacionesEN
    {
        //atributos privados
        private UsuarioEN usuarioReclama;
        private string reclamacion { get; set; }
        private string fecha { get; set; }
        private bool devolucion { get; set; }


        //metodos publicos

        public UsuarioEN GetUsuarioReclama() { return usuarioReclama; }
        public string getReclamacion() { return reclamacion; }
        public string getFecha() { return fecha; }
        public bool getDevolucion() { return devolucion; }


        public ReclamacionesEN()
        {
            usuarioReclama = new UsuarioEN();
            reclamacion = "";
            fecha = "";
            devolucion = false;
        }

        public ReclamacionesEN(UsuarioEN usuarioReclama, string reclamacion, string fecha, bool devolucion)
        {
            this.usuarioReclama = usuarioReclama;
            this.reclamacion = reclamacion;
            this.fecha = fecha;
            this.devolucion = devolucion;
        }

        public bool createReclamacion()
        {
            bool creado = false;
            ReclamacionesCAD cad = new ReclamacionesCAD();
            if (cad.createReclamacion(this)) creado = true;
            return creado;
        }

        public bool updateReclamacion()
        {
            bool updated = false;
            ReclamacionesCAD cad = new ReclamacionesCAD();
            if (cad.updateReclamacion(this)) updated = true;
            return updated;
        }

        public bool readReclamacion()
        {
            bool leida = false;
            ReclamacionesCAD cad = new ReclamacionesCAD();
            if (cad.createReclamacion(this)) leida = true;
            return leida;
        }

        public bool deleteReclamacion()
        {
            bool borrada = false;
            ReclamacionesCAD cad = new ReclamacionesCAD();
            if (cad.createReclamacion(this)) borrada = true;
            return borrada;
        }

    }
}
