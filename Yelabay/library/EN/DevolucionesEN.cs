using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace library
{
    public class DevolucionesEN 
    {
        private int idDevolucion;
        private string motivo;
        private string fechaDevolucion;
        private int idPedido;
        private float dineroADevolver;
      
        public int getId()
        {
            return idDevolucion;
        }
        
        public void setId(int idDev)
        {
            idDevolucion = idDev;
        }

        public string getMotivo()
        {
            return motivo;
        }

        public void setMotivo(string motivo)
        {
            this.motivo = motivo;
        }

        public string getFechaDevolucion()
        {
            return fechaDevolucion;
        }

        public void setFechaDevolucion(string fechaDev)
        {
            fechaDevolucion = fechaDev;
        }

        public int getCodigoPedido()
        {
            return idPedido;
        }

        public void setCodigoPedido(int codPed)
        {
            idPedido = codPed;
        }

        public float getDineroADevolver()
        {
            return dineroADevolver;
        }
       
        public void setDineroADevolver(float dineroADevolver)
        {
            this.dineroADevolver = dineroADevolver;
        }



        public DevolucionesEN(string motivo,  float dineroADevolver)
        {
            idDevolucion = 0;
            this.motivo = motivo;
            fechaDevolucion = "";
            idPedido = 0;
            this.dineroADevolver = dineroADevolver;
        }

        public DevolucionesEN(int id,string motivo, string fechaDev, int codigoPedido, float dineroADevolver)
        {
            idDevolucion = id;
            this.motivo = motivo;
            fechaDevolucion = fechaDev;
            idPedido = codigoPedido;
            this.dineroADevolver = dineroADevolver;
        }

        public DevolucionesEN()
        {
            idDevolucion = 0;
            motivo = "";
            fechaDevolucion = "";
            idPedido = 0;
            dineroADevolver = 0;
        }
        public bool createDevolucion()
        {
            DevolucionesCAD devCad = new DevolucionesCAD();
            return devCad.createDevolucion(this);
        }

        public bool updateDevolucion()
        {
            DevolucionesCAD devCad = new DevolucionesCAD();
            return devCad.deleteDevolucion(this);
        }

        public bool deleteDevolucion()
        {
            DevolucionesCAD devCad = new DevolucionesCAD();
            return devCad.deleteDevolucion(this);
        }
    }
}
