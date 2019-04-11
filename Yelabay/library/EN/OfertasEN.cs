using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class OfertasEN
    {

        private string fechaInicio;

        private string fechaFin;

        private int codigoOferta;

        private float descuento;

        public OfertaEN(int codigoOferta, string fechaInicio, string fechaFin, float descuento)
        {
            this.fechaInicio=fechaInicio;
            this.fechaFin=fechaFin;
            this.codigoOferta=codigoOferta;
            this.descuento=descuento;
        }

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



    }
}
