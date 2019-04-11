using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class MarcaEN
    {
        private int idMarca;

        private string nombre;

        public MarcaEN() 
        {

            idMarca=0;
            nombre="";
        }

        public int getIdMarca() 
        {
            return idMarca;
        }

        public void setIdMarca(int idMarca) 
        {
            this.idMarca=idMarca;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre=nombre;
        }
    }
}
