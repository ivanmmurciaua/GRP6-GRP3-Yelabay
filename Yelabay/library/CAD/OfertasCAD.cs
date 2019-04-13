using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class OfertasCAD
    {

        private string constring;

        public OfertasCAD()
        {
            //constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            constring="";
        }

        public bool createOferta(OfertasEN oferEn)
        {
            return true;
        }

        public bool updateOferta(OfertasEN oferEn)
        {
            return true;
        }

        public bool deleteOferta(OfertasEN oferEn)
        {
            return true;
        }

        public bool readOferta(OfertasEN oferEn)
        {
            return true;
        }

    }
}
