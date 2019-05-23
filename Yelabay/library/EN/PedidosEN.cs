using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
    public class PedidosEN
    {
        private UsuarioEN usuario;
        private ProductoEN producto;
        
        private int id { get; set; }
        private string fechaCompra { get; set; }
        private string fechaEmpaquetado { get; set; }
        private string fechaEnvio { get; set; }
        private string fechaEntrega { get; set; }
        private string direccion { get; set; }
        private string ciudad { get; set; }
        private string pais { get; set; }
        private float precioSinIVA { get; set; }
        private int IVA { get; set; }
        private float precioConIVA { get; set; }
        private string agenciaDeTransporte { get; set; }
        private string estado { get; set; }
        
        public  int id_pbl
        {
            get { return id; }
            set { id = value; }
        }
        public string fechaCompra_pbl
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }
        public string fechaEmpaquetado_pbl
        {
            get { return fechaEmpaquetado; }
            set { fechaEmpaquetado = value; }
        }
        public string fechaEnvio_pbl
        {
            get { return fechaEnvio; }
            set { fechaEnvio = value; }
        }
        public string fechaEntrega_pbl
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        public string direccion_pbl
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string ciudad_pbl
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string pais_pbl
        {
            get { return pais; }
            set { pais = value; }
        }
        public float precioSinIVA_pbl
        {
            get { return precioSinIVA; }
            set { precioSinIVA = value; }
        }
        public int IVA_pbl
        {
            get { return IVA; }
            set { IVA = value; }
        }
        public float precioConIVA_pbl
        {
            get { return precioConIVA; }
            set { precioConIVA = value; }
        }
        public string agenciaDeTransporte_pbl
        {
            get { return agenciaDeTransporte; }
            set { agenciaDeTransporte = value; }
        }
        public string estado_pbl
        {
            get { return estado; }
            set { estado = value; }
        }
        public PedidosEN()
        {
            id = 0;
            fechaCompra = "";
            fechaEmpaquetado = "";
            fechaEntrega = "";
            direccion = "";
            ciudad = "";
            pais = "";
            precioSinIVA = 0;
            IVA = 0;
            precioConIVA = 0;
        }
        public PedidosEN(string fechaCompra, string fechaEmpaquetado, string fechaEntrega, string pais, string ciudad, string direccion, int precioSinIVA, int precioConIVA, int IVA)
        {
            id = 0;
            this.fechaCompra = fechaCompra;
            this.fechaEmpaquetado = fechaEmpaquetado;
            this.fechaEntrega = fechaEntrega;
            this.pais = pais;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.precioSinIVA = precioSinIVA;
            this.precioConIVA = precioConIVA;
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

            cad.readPedido(this);
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
        public DataSet ListarPedidos()
        {
            PedidosCAD cadp = new PedidosCAD();

            return cadp.ListarPedidos(this);
        }
    }
}

