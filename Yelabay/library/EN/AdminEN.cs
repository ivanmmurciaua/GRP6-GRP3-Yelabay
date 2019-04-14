using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library{

    public class AdminEN{

        private int claveAdmin {get; set;}

        public AdminEN(int claveAdmin){
            this.claveAdmin = claveAdmin;
        }

         //Funciones publicas
        public bool createAdmin()
        {
            AdminCAD admin=new AdminCAD();

            return admin.createAdmin(this);
        }

        public bool updateAdmin()
        {
            AdminCAD admin=new AdminCAD();

            return admin.updateAdmin(this);
        }

        public bool deleteAdmin()
        {
            AdminCAD admin=new AdminCAD();

            return admin.deleteAdmin(this);
        }

        public bool readAdmin()
        {
            AdminCAD admin=new AdminCAD();

            return admin.readAdmin(this);
        }

        public void AsignarAdmin(){
            /**/
        }

        public void consultarServicioTecnico(){
            /**/
        }

        public void comprobarPedidos(){
            /**/
        }
    }
}