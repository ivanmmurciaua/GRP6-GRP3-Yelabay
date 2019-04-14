using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace library
{
    public class DevolucionesEN 
    {
        private string motivo;
        private float dineroADevolver;
      

        public string getMotivo()
        {
            return motivo;
        }

        public void setMotivo(string motivo)
        {
            this.motivo = motivo;
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
            this.motivo = motivo;
            this.dineroADevolver = dineroADevolver;
        }
        
        public DevolucionesEN()
        {
            motivo = "";
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
