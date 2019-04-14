using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library{
    public class AdminCAD{

        private string constring;

        public AdminCAD(){
            //constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            constring="";
        }

        public bool createAdmin(AdminEN admin){
            return true;
        }

        public bool updateAdmin(AdminEN admin){
            return true;
        }

        public bool deleteAdmin(AdminEN admin){
            return true;
        }

        public bool readAdmin(AdminEN admin){
            return true;
        }
    }
}