using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ServicioTecnicoEN
    {

        private UsuarioEN usuario;
        private string fechaConsulta { get; set; }
        private string consulta { get; set; }
        private string respuesta { get; set; }

        public string getFechaConsulta() { return fechaConsulta; }
        public string getConsulta() { return consulta; }
        public string getRespuesta() { return respuesta; }
        public ServicioTecnicoEN()
        {
            fechaConsulta = "";
            consulta = "";
        }
        public ServicioTecnicoEN( string fechaConsulta, string consulta, string respuesta )
        {
            this.fechaConsulta = fechaConsulta;
            this.consulta = consulta;
            this.respuesta = respuesta;

        }
        public void createServicioTecnicoEN()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            ServicioTecnicoEN en = new ServicioTecnicoEN();
            cad.createServicioTecnico(en);
        }
        public void readServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            ServicioTecnicoEN en = new ServicioTecnicoEN();
            cad.readServicioTecnico(en);
            fechaConsulta = en.fechaConsulta;
            consulta = en.consulta;
            respuesta = en.respuesta;
        }
        public void updateServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            ServicioTecnicoEN en = new ServicioTecnicoEN();
            cad.updateServicioTecnico(en);
        }
        public void deleteServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            ServicioTecnicoEN en = new ServicioTecnicoEN();
            cad.deleteServicioTecnico(en);
        }
    }
}
