using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class MarcaEN
    {

        //Atributos privados
        private int idMarca{get; set;}//Id de la marca
        private string nombre{get; set;}//Nombre de la marca

        //Getters
        public int getIdMarca() 
        {
            return idMarca;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setIdMarca(int marc)
        {
            idMarca = marc;
        }

        public void setNombre(string nomb)
        {
            nombre = nomb;
        }


        //Constructores
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

        //Funciones publicas
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

        public bool readMarca()
        {
            MarcaCAD marCad=new MarcaCAD();

            return marCad.readMarca(this);
        }



    }
}
