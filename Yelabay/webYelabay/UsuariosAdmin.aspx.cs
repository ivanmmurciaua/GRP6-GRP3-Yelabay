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
    public partial class UsuariosAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RellenarGridView();
            }
        }
        public void RellenarGridView()
        {
            UsuarioEN usuEN = new UsuarioEN();
            DataSet da = new DataSet();
            da = usuEN.ListarUsuarios();
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridUsuariosAdmin.DataSource = da;
                    GridUsuariosAdmin.DataBind();
                }
                else
                {
                    GridUsuariosAdmin.DataSource = null;
                    GridUsuariosAdmin.DataBind();
                }
            }
        }


        protected void GridUsuariosAdmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName.Equals("Añadir"))
            {
                try
                {

                    String nomb = (GridUsuariosAdmin.FooterRow.FindControl("textNombreFooter") as TextBox).Text.Trim().ToString();
                    
                    String apelli = (GridUsuariosAdmin.FooterRow.FindControl("textApellidosFooter") as TextBox).Text.Trim().ToString();
                    String ni = (GridUsuariosAdmin.FooterRow.FindControl("textNifFooter") as TextBox).Text.Trim().ToString();
                    String emal = (GridUsuariosAdmin.FooterRow.FindControl("textEmailFooter") as TextBox).Text.Trim().ToString();
                    String contra = (GridUsuariosAdmin.FooterRow.FindControl("textContraseñaFooter") as TextBox).Text.Trim().ToString();
                    String tip = (GridUsuariosAdmin.FooterRow.FindControl("textDireccionFooter") as TextBox).Text.Trim().ToString();
                    String nicki = (GridUsuariosAdmin.FooterRow.FindControl("textNickFooter") as TextBox).Text.Trim().ToString();
                    String telef = (GridUsuariosAdmin.FooterRow.FindControl("textTelefonoFooter") as TextBox).Text.Trim().ToString();
                    /*
                    int fkMarc = Int32.Parse((GridUsuariosAdmin.FooterRow.FindControl("textFKMarcaFooter") as TextBox).Text.Trim().ToString());
                    //int fkOfert = Int32.Parse((GridProductosAdmin.FooterRow.FindControl("textFKOfertaFooter") as TextBox).Text.Trim().ToString());
                    int fkCate = Int32.Parse((GridUsuariosAdmin.FooterRow.FindControl("textFKCategoriaFooter") as TextBox).Text.Trim().ToString());
                    float prec = (float)Convert.ToSingle((GridUsuariosAdmin.FooterRow.FindControl("textPrecioFooter") as TextBox).Text);
                    int stck = Int32.Parse((GridUsuariosAdmin.FooterRow.FindControl("textStockFooter") as TextBox).Text.Trim().ToString());
                    */

                    UsuarioEN usuEN = new UsuarioEN(emal, nomb,"" ,contra, apelli, ni, 0, nicki, telef);

                    
                    usuEN.createUsuario();
                    LabelMensajeExito.Text = "¡Producto añadido correctamente!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                    LabelMensajeError.Text = "¡ERROR al añadir el producto!";
                }
                RellenarGridView();
                
                    
                
                    
                


            }
        }



        protected void GridUsuariosAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridUsuariosAdmin.EditIndex = e.NewEditIndex;
            RellenarGridView();
        }

        protected void GridUsuariosAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridUsuariosAdmin.EditIndex = -1;
            RellenarGridView();
        }



        protected void GridUsuariosAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int identi = Int32.Parse(GridUsuariosAdmin.DataKeys[e.RowIndex].Value.ToString());
            
            String nomb = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNombre") as TextBox).Text.Trim().ToString();

            String apelli = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textApellidos") as TextBox).Text.Trim().ToString();
            String ni = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNif") as TextBox).Text.Trim().ToString();
            String emal = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textEmail") as TextBox).Text.Trim().ToString();
            String contra = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textContraseña") as TextBox).Text.Trim().ToString();
            String tip = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textDireccion") as TextBox).Text.Trim().ToString();
            String nicki = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textNick") as TextBox).Text.Trim().ToString();
            String telef = (GridUsuariosAdmin.Rows[e.RowIndex].FindControl("textTelefono") as TextBox).Text.Trim().ToString();


            

            UsuarioEN usuEN = new UsuarioEN(emal, nomb, "", contra, apelli, ni, identi, nicki, telef);
            

            bool actualizado = usuEN.actualizarUsuario();
            GridUsuariosAdmin.EditIndex = -1;
            RellenarGridView();

            if (actualizado)
            {
                LabelMensajeExito.Text = "¡Usuario actualizado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al actualizar el usuario!";
            }
        }

        protected void GridUsuariosAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridUsuariosAdmin.DataKeys[e.RowIndex].Value.ToString());

            UsuarioEN usuEN = new UsuarioEN();
            usuEN.Id = identi;

            bool borrado = usuEN.borrarUsuario();

            RellenarGridView();

            if (borrado)
            {
                LabelMensajeExito.Text = "¡Producto borrado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al borrar el producto!";
            }

        }








    }
}