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
        private int codigoOferta{get; set;}//codigo de la oferta
        private string fechaInicio {get; set;}//fecha de inicio de la oferta
        private string fechaFin{get; set;}//fecha de fin de la oferta
        private int descuentoPorcen{get; set;}//porcentaje de descuento de la oferta
        private float diferencia { get; set; }

        //Getters
        public int getCodigoOferta()
        {
            return codigoOferta;
        }
        public string getFechaInicio()
        {
            return fechaInicio;
        }

        public string getFechaFin()
        {
            return fechaFin;
        }

        public int getDescuentoPorcen()
        {
            return descuentoPorcen;
        }

        public float getDiferencia()
        {
            return diferencia;
        }



        public void setCodigoOferta(int cod)
        {
            codigoOferta = cod;
        }
        public void setFechaInicio(string fech)
        {
            fechaInicio=fech;
        }

        public void setFechaFin(string fecha)
        {
            fechaFin=fecha;
        }

        public void setDescuentoPorcen(int porcen)
        {
            descuentoPorcen=porcen;
        }

        public void setDiferencia(float dife)
        {
            diferencia = dife;
        }



        //Constructores
        public OfertasEN()
        {
            fechaInicio="";
            fechaFin="";
            codigoOferta=0;
            descuentoPorcen=0;
        }

        public OfertasEN(int codigoOferta, string fechaInicio, string fechaFin, int descuento, float diferencia)
        {
            this.fechaInicio=fechaInicio;
            this.fechaFin=fechaFin;
            this.codigoOferta=codigoOferta;
            this.descuentoPorcen=descuento;
            this.diferencia = diferencia;
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
