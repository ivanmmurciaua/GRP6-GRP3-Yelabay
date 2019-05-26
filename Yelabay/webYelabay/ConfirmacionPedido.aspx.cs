﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;

namespace webYelabay
{
    public partial class ConfirmacionPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IniciarLlenadoDropDown();
                LabelEuro.Visible = false;
                LabelPrecioEnvio.Text = 0.ToString();
                LabelPrecioEnvio.Visible = false;
                //LabelPrecioTotalSinIVA.Text =.Text.toString();
                //LabelPrecioTotal.Text =.Text.toString();
            }
        }

        private void IniciarLlenadoDropDown()
        {
            DropListAgTrans.DataSource = Consultar();
            DropListAgTrans.DataTextField = "nombre";
            DropListAgTrans.DataValueField = "id";
            DropListAgTrans.DataBind();
            DropListAgTrans.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void DropListAgTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropListAgTrans.SelectedValue);

            AgenciaTEN agtEn = new AgenciaTEN();
            agtEn.codigo_pbl = id;
            agtEn.leerAgenciaT();
            LabelPais.Text = agtEn.pais_pbl;
            //rellenar con precios carrito
            LabelPrecioEnvio.Text = agtEn.precioEnvio_pbl.ToString();
            LabelPrecioTotalSinIVA.Text = (agtEn.precioEnvio_pbl).ToString();
            LabelPrecioTotal.Text = (agtEn.precioEnvio_pbl).ToString();
            
            if (id != 0)
            {
                LabelEuro.Visible = true;
                
                LabelPrecioEnvio.Visible = true;
            }
            else
            {
                LabelEuro.Visible = false;
               
                LabelPrecioEnvio.Visible = false;
            }


        }

        public DataSet Consultar()
        {
            AgenciaTEN agtEN = new AgenciaTEN();
            return agtEN.ListarAgenciaT();
        }

        protected void ButtonConfirmarPedido_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(DropListAgTrans.SelectedValue) != 0) && TextBoxDireccion.Text != "" && TextBoxCiudad.Text != "" && TextBoxPais.Text != "")
            {
                DateTime thisDay = DateTime.Today;


                int id = Convert.ToInt32(DropListAgTrans.SelectedValue);
                PedidosEN pedEn = new PedidosEN();
                pedEn.direccion_pbl = TextBoxDireccion.Text.ToString();
                pedEn.ciudad_pbl = TextBoxCiudad.Text.ToString();
                pedEn.pais_pbl = TextBoxPais.Text.ToString();
                pedEn.agenciaDeTransporte_pbl = id.ToString();
                int idUsu = ((UsuarioEN)Session["Usuarios"]).Id;
                pedEn.precioSinIVA_pbl = Convert.ToSingle(LabelPrecioTotalSinIVA.Text.ToString());
                pedEn.precioConIVA_pbl = Convert.ToSingle(LabelPrecioTotal.Text.ToString());
                pedEn.fechaCompra_pbl = thisDay.ToString("d");
                pedEn.estado_pbl = "Recibido";
                //pedEn.createPedido(idUsu);
                //Response.Redirect("VerTodosProductos.aspx");
            }
            else
            {
                LabelMensajeError.Text = "Error al rellenar los datos. Intentelo de nuevo";
            }


        }
    }
}