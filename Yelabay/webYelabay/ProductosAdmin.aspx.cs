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
    public partial class ProductosAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RellenarGridView();
            }
        }

        /*
Voy a dejar: Nombre, Precio(en$) Stock, Campo Oferta.
*/

        public void RellenarGridView()
        {
            ProductoEN prodEN = new ProductoEN();
            DataSet da = new DataSet();
            da = prodEN.ListarProductos();
            //FORMA PARA QUE CUALQUIER COLUMNA DEL GRID LA HAGAMOS DESAPARECER, SU DESTINO A NUESTRA MERCED.
            this.GridProductosAdmin.Columns[0].Visible = false; //COLUMNA DE LA ID EN FALSE.
            this.GridProductosAdmin.Columns[3].Visible = false; //COLUMNA DE LA ID MARCA.
            this.GridProductosAdmin.Columns[4].Visible = false; //COLUMNA DE LA ID MARCA.
            this.GridProductosAdmin.Columns[7].Visible = false; //COLUMNA DE LA DESCRIPCION EN FALSE.
            this.GridProductosAdmin.Columns[8].Visible = false; //COLUMNA DE LA FOTITO EN FALSE.

            if (da != null)
            {
                ;
                if (da.Tables[0].Rows.Count != 0)
                {
                    
                    GridProductosAdmin.DataSource = da;
                    GridProductosAdmin.DataBind();
                    
                }
                else
                {
                    GridProductosAdmin.DataSource = null;
                    GridProductosAdmin.DataBind();
                }
            }
        }

        protected void GridProductosAdmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            bool añadido = false;
            if (e.CommandName.Equals("Añadir"))
            {
                try
                {
                    String nomb = (GridProductosAdmin.FooterRow.FindControl("textNombreFooter") as TextBox).Text.Trim().ToString();
                    float prec = (float)Convert.ToSingle((GridProductosAdmin.FooterRow.FindControl("textPrecioFooter") as TextBox).Text);
                    int stck = Int32.Parse((GridProductosAdmin.FooterRow.FindControl("textStockFooter") as TextBox).Text.Trim().ToString());
                    float ofert = (float)Convert.ToSingle((GridProductosAdmin.FooterRow.FindControl("textOfertaFooter") as TextBox).Text);
                    String descr = (GridProductosAdmin.FooterRow.FindControl("textDescripcionFooter") as TextBox).Text.Trim().ToString();
                    String fot = (GridProductosAdmin.FooterRow.FindControl("textFotoFooter") as TextBox).Text.Trim().ToString();

                    int fkMarc = Int32.Parse((GridProductosAdmin.FooterRow.FindControl("textFKMarcaFooter") as TextBox).Text.Trim().ToString());
                    //int fkOfert = Int32.Parse((GridProductosAdmin.FooterRow.FindControl("textFKOfertaFooter") as TextBox).Text.Trim().ToString());
                    int fkCate = Int32.Parse((GridProductosAdmin.FooterRow.FindControl("textFKCategoriaFooter") as TextBox).Text.Trim().ToString());


                    ProductoEN prodEN = new ProductoEN(0, nomb,descr,stck,fot);

                    prodEN.setPrecio(prec);
                    añadido = prodEN.crearProductos(fkMarc, 0, fkCate);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("User operation has failed.Error: { 0} ", ex.Message);
                }
                RellenarGridView();
                if (añadido)
                {
                    LabelMensajeExito.Text = "¡Producto añadido correctamente!";
                }
                else
                {
                    LabelMensajeError.Text = "¡ERROR al añadir el producto!";
                }


            }
        }

        protected void GridProductosAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridProductosAdmin.EditIndex = e.NewEditIndex;
            RellenarGridView();
        }

        protected void GridProductosAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridProductosAdmin.EditIndex = -1;
            RellenarGridView();
        }

        protected void GridProductosAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int identi = Int32.Parse(GridProductosAdmin.DataKeys[e.RowIndex].Value.ToString());
            String nomb = (GridProductosAdmin.Rows[e.RowIndex].FindControl("textNombre") as TextBox).Text.Trim().ToString();
            float prec = (float)Convert.ToSingle((GridProductosAdmin.Rows[e.RowIndex].FindControl("textPrecio") as TextBox).Text.ToString());
            int stck = Int32.Parse((GridProductosAdmin.Rows[e.RowIndex].FindControl("textStock") as TextBox).Text.Trim().ToString());
            float ofert = (float)Convert.ToSingle((GridProductosAdmin.Rows[e.RowIndex].FindControl("textOferta") as TextBox).Text.ToString());
            String descr = (GridProductosAdmin.Rows[e.RowIndex].FindControl("textDescripcion") as TextBox).Text.Trim().ToString();
            String fot = (GridProductosAdmin.Rows[e.RowIndex].FindControl("textFoto") as TextBox).Text.Trim().ToString();

            int fkMarc = Int32.Parse((GridProductosAdmin.Rows[e.RowIndex].FindControl("textFKMarca") as TextBox).Text.Trim().ToString());
            //int fkOfert = Int32.Parse((GridProductosAdmin.Rows[e.RowIndex].FindControl("textFKOferta") as TextBox).Text.Trim().ToString());
            int fkCate = Int32.Parse((GridProductosAdmin.Rows[e.RowIndex].FindControl("textFKCategoria") as TextBox).Text.Trim().ToString());


            ProductoEN prodEN = new ProductoEN(identi, nomb,descr, stck,fot);
            prodEN.setPrecio(prec);

            bool actualizado = prodEN.actualizarProductos(fkMarc, 0, fkCate);
            GridProductosAdmin.EditIndex = -1;
            RellenarGridView();

            if (actualizado)
            {
                LabelMensajeExito.Text = "¡Producto actualizado correctamente!";
            }
            else
            {
                LabelMensajeError.Text = "¡ERROR al actualizar el producto!";
            }
        }

        protected void GridProductosAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridProductosAdmin.DataKeys[e.RowIndex].Value.ToString());

            ProductoEN prodEN = new ProductoEN();
            prodEN.setCodigo(identi);

            bool borrado = prodEN.borrarProductos();

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
 