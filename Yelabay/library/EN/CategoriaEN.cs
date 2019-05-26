using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CategoriaEN 
    {
        //Campos privados para mantener el estado de la Entidad Categoria
        private int codCategoria;
        private string nombre;

        //Propiedades públicas para exponer el estado de la categoria.
        public int getCodCategoria()
        {
            return codCategoria;
        }

        public void setCodCategoria(int codCategoria)
        {
            this.codCategoria = codCategoria;
        }
        
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        
        public CategoriaEN()
        {
            codCategoria = 0;
            nombre = "";
        }

        public CategoriaEN(int codCategoria, string nombre)
        {
            this.codCategoria = codCategoria;
            this.nombre = nombre;

        }

        public bool createCategoria()
        {
            CategoriaCAD catCad = new CategoriaCAD();

            return catCad.updateCategoria(this);
        }

        public bool deleteCategoria()
        {
            CategoriaCAD catCad = new CategoriaCAD();
            return catCad.deleteCategoria(this);
        }
        
    }
}
