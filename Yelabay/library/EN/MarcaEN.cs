using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class MarcaEN
    {
        private int idMarca;

        private string nombre;

        public int getIdMarca() 
        {
            return idMarca;
        }

        private void setIdMarca(int idMarca) 
        {
            this.idMarca=idMarca;
        }

        public string getNombre()
        {
            return nombre;
        }

        private void setNombre(string nombre)
        {
            this.nombre=nombre;
        }

        public MarcaEN() 
        {
            idMarca=0;
            nombre="";
        }

        public MarcaEN(int idMarca, string nombre) 
        {
            this.idMarca=idMarca;
            this.nombre=nombre;
        }

        public bool createMarca()
        {
            MarcaCAD marCad=new MarcaCAD();

            return marCad.createMarca(this);
        }

        public bool updateMarca()
        {
            MarcaCAD marCad=new MarcaCAD();

            return marCad.updateMarca(this);
        }

        public bool deleteMarca()
        {
            MarcaCAD marCad=new MarcaCAD();

            return marCad.deleteMarca(this);
        }




    }
}
