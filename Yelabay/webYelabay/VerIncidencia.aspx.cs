using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;


namespace webYelabay
{
    public partial class VerIncidencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RellenarGridView();
            }
        }

        public void RellenarGridView()
        {
            UsuarioEN usu = new UsuarioEN();
            usu = (UsuarioEN)Session["Usuarios"];
            ReclamacionesEN recEN = new ReclamacionesEN();
            DataSet da = new DataSet();
            da = recEN.ListarReclamacionUsu(usu.getId());
            if(da != null)
            {
                if(da.Tables[0].Rows.Count != 0)
                {
                    GridIncidenciasUser.DataSource = da;
                    GridIncidenciasUser.DataBind();
                }
                else
                {
                    GridIncidenciasUser.DataSource = da;
                    GridIncidenciasUser.DataBind();
                }
            }
        }
        /*protected void GridIncidenciasUser_RowCommand(object sender, GridViewCommandEventArgs e) ESTO SERIA PARA AÑADIR, NO HACE FALTA EN MENU DE USUARIO
        {
             if(e.CommandName.Equals("Añadir"))
            {
                try
                {
                    String fecRec = (GridIncidenciasUser.FooterRow.FindControl("textfechaRec") as TextBox).Text.Trim().ToString();
                    String motivoRec = (GridIncidenciasUser.FooterRow.FindControl("motivoReclamacion") as TextBox).Text.Trim().ToString();

                    ReclamacionesEN recEN = new ReclamacionesEN();

                    recEN.
                }
            }
        }*/
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerTodasIncidencias.aspx?ReclamacionesID=" + ((LinkButton)sender).Text);
        }
        
        protected void GridIncidenciasUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}