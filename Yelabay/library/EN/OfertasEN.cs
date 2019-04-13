using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class OfertasEN
    {
        //Atributos privados
        private string fechaInicio;//fecha de inicio de la oferta
        private string fechaFin;//fecha de fin de la oferta
        private int codigoOferta;//codigo de la oferta
        private float descuento;//descuento de la oferta

        //getters y setters
        public string getFechaInicio()
        {
            return fechaInicio;
        }

        public void setFechaInicio(string fechaInicio)
        {
            this.fechaInicio=fechaInicio;
        }

        public string getFechaFin()
        {
            return fechaFin;
        }

        public void setFechaFin(string fechaFin)
        {
            this.fechaFin=fechaFin;
        }

        public int getCodigoOferta()
        {
            return codigoOferta;
        }

        public void setCodigoOferta(int codigoOferta)
        {
            this.codigoOferta=codigoOferta;
        }

        public float getDescuento()
        {
            return descuento;
        }

        public void setDescuento(float descuento)
        {
            this.descuento=descuento;
        }

        //constructores
        public OfertasEN()
        {
            fechaInicio="";
            fechaFin="";
            codigoOferta=0;
            descuento=0;
        }

        public OfertaEN(int codigoOferta, string fechaInicio, string fechaFin, float descuento)
        {
            this.fechaInicio=fechaInicio;
            this.fechaFin=fechaFin;
            this.codigoOferta=codigoOferta;
            this.descuento=descuento;
        }

        //Funciones publicas
        public bool createOferta()
        {
            OfertasCAD oferCad=new OfertasCAD();

            return oferCad.createOferta(this);
        }

        public bool updateOferta()
        {
            OfertasCAD oferCad=new OfertasCAD();

            return oferCad.updateOferta(this);
        }

        public bool deleteOferta()
        {
            OfertasCAD oferCad=new OfertasCAD();

            return oferCad.deleteOferta(this);
        }

        public bool readOferta()
        {
            OfertasCAD oferCad=new OfertasCAD();

            return oferCad.readOferta(this);
        }


    }
}
