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
    public class AgenciaTEN
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private string pais { get; set; }
        private float precioEnvio { get; set; }

        public int codigo_pbl
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string nombre_pbl
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string pais_pbl
        {
            get { return pais; }
            set { pais = value; }
        }

        public float precioEnvio_pbl
        {
            get { return precioEnvio; }
            set { precioEnvio = value; }
        }

        public AgenciaTEN()
        {
            codigo = 0;
            nombre = "";
            pais = "";
            precioEnvio = 0;
        }
        public AgenciaTEN(int cod, string nom, string pais2, float precioEnv)
        {
            codigo = cod;
            nombre = nom;
            pais = pais2;
            precioEnvio = precioEnv;
        }

        public bool crearAgenciaT()
        {
            AgenciasTCAD agtCAD = new AgenciasTCAD();

            return agtCAD.crearAgenciaT(this);
        }

        public bool actualizarAgenciaT()
        {
            AgenciasTCAD agtCAD = new AgenciasTCAD();

            return agtCAD.actualizarAgenciaT(this);
        }
        public bool borrarAgenciaT()
        {
            AgenciasTCAD agtCAD = new AgenciasTCAD();

            return agtCAD.borrarAgenciaT(this);
        }
        public bool leerAgenciaT()
        {
            AgenciasTCAD agtCAD = new AgenciasTCAD();

            return agtCAD.leerAgenciaT(this);
        }

        public DataSet ListarAgenciaT()
        {
            AgenciasTCAD agtCAD = new AgenciasTCAD();

            return agtCAD.ListarAgenciaT(this);
        }

    }
}
