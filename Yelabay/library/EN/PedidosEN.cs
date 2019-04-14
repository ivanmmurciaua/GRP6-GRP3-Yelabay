using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class PedidosEN
    {
        private UsuarioEN usuario;
        private ProductoEN producto;
        private int numPedido { get; set; }
        private int articulos { get; set; }
        private string fechaCompra { get; set; }
        private string fechaEntrega { get; set; }
        private string paisEntrega { get; set; }
        private string ciudadEntrega { get; set; }
        private string direccionEntrega { get; set; }
        private string agenciaDeTransporte { get; set; }

        public int getNumPedido() { return numPedido; }
        public int getArticulos() { return articulos; }
        public string getFechaCompra() { return fechaCompra; }
        public string getFechaEntrega() { return fechaEntrega; }
        public string getPaisEntrega() { return paisEntrega; }
        public string getCiudadEntrega() { return ciudadEntrega; }
        public string getDireccionEntrega() { return direccionEntrega; }
        public string getAgenciaDeTransporte() { return agenciaDeTransporte; }
        public PedidosEN()
        {
            numPedido = 0;
            articulos = 0;
            fechaCompra = "";
            fechaEntrega = "";
            paisEntrega = "";
            ciudadEntrega = "";
            direccionEntrega = "";
            agenciaDeTransporte = "";
        }
        public PedidosEN( int numPedido, int articulos, string fechaCompra, string fechaEntrega, string paisEntrega, string ciudadEntrega, string direccionEntrega, string agenciaDeTransporte )
        {
            this.numPedido = numPedido;
            this.articulos = articulos;
            this.fechaCompra = fechaCompra;
            this.fechaEntrega = fechaEntrega;
            this.paisEntrega = paisEntrega;
            this.ciudadEntrega = ciudadEntrega;
            this.direccionEntrega = direccionEntrega;
            this.agenciaDeTransporte = agenciaDeTransporte;

        }
        public void createPedido()
        {
            PedidosCAD cad = new PedidosCAD();
            PedidosEN en = new PedidosEN();
            cad.createPedido(en);
        }
        public void readPedido()
        {
            PedidosCAD cad = new PedidosCAD();
            PedidosEN en = new PedidosEN();
            cad.readPedido(en);
            numPedido = en.numPedido;
            articulos = en.articulos;
            fechaCompra = en.fechaCompra;
            fechaEntrega = en.fechaEntrega;
            paisEntrega = en.paisEntrega;
            ciudadEntrega = en.ciudadEntrega;
            direccionEntrega = en.direccionEntrega;
            agenciaDeTransporte = en.agenciaDeTransporte;
        }
        public void updatePedido()
        {
            PedidosCAD cadp = new PedidosCAD();
            PedidosEN en = new PedidosEN();
            cadp.updatePedido(en);
        }
        public void deletePedido()
        {
            PedidosCAD cadp = new PedidosCAD();
            PedidosEN en = new PedidosEN();
            cadp.deletePedido(en);
        }
    }
}
