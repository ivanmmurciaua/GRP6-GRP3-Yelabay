using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ServicioTecnicoEN
    {
        private int idST;
        //private UsuarioEN usuario;
        private int fkusuario;
        private string fechaConsulta { get; set; }
        private string consulta { get; set; }
        private string respuesta { get; set; }

        public int getId() { return idST; }
        public string getFechaConsulta() { return fechaConsulta; }
        public string getConsulta() { return consulta; }
        public string getRespuesta() { return respuesta; }
        public int getFkUsuario() { return fkusuario; }

        public void setId(int id)
        {
            idST = id;
        }
        public void setFechaConsulta(string fech)
        {
            fechaConsulta = fech;
        }

        public void setConsulta(string consul)
        {
            consulta = consul;
        }

        public void setRespuesta(string resp)
        {
            respuesta = resp;
        }
        public void setFKusu(int usu)
        {
            fkusuario = usu;
        }


        public ServicioTecnicoEN()
        {
            idST = 0;
            fechaConsulta = "";
            consulta = "";
            respuesta = "";
            fkusuario = 0;
        }
        public ServicioTecnicoEN( string fechaConsulta, string consulta, string respuesta )
        {
            idST = 0;
            this.fechaConsulta = fechaConsulta;
            this.consulta = consulta;
            this.respuesta = respuesta;

        }
        public void createServicioTecnicoEN()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            
            cad.createServicioTecnico(this);
        }
        public void readServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            
            cad.readServicioTecnico(this);
            
        }
        public void updateServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            
            cad.updateServicioTecnico(this);
        }
        public void deleteServicioTecnico()
        {
            ServicioTecnicoCAD cad = new ServicioTecnicoCAD();
            
            cad.deleteServicioTecnico(this);
        }
    }
}
