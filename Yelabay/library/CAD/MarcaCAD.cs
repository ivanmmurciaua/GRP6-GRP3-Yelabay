using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class MarcaCAD
    {
        private string constring;

        public MarcaCAD()
        {
            //constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            constring="";
        }

        public bool createMarca(MarcaEN marcEn)
        {
            return true;
        }

        public bool updateMarca(MarcaEN marcEn)
        {
            return true;
        }

        public bool deleteMarca(MarcaEN marcEn)
        {
            return true;
        }

        public bool readMarca(MarcaEN marcEn)
        {
            return true;
        }

    }
}
