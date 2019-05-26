using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

using System.Data;

namespace webYelabay
{
    public partial class ReclamacionesAdmin : System.Web.UI.Page
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
            ReclamacionesEN rec = new ReclamacionesEN();
            DataSet da = new DataSet();
            da = rec.ListarReclamaciones();
            if (da != null)
            {
                if (da.Tables[0].Rows.Count != 0)
                {
                    GridReclamacionesAdmin.DataSource = da;
                    GridReclamacionesAdmin.DataBind();
                }
                else
                {
                    GridReclamacionesAdmin.DataSource = null;
                    GridReclamacionesAdmin.DataBind();
                }
            }
        }

        protected void GridUsuariosAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridReclamacionesAdmin.EditIndex = -1;
            RellenarGridView();
        }

        protected void GridUsuariosAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int identi = Int32.Parse(GridReclamacionesAdmin.DataKeys[e.RowIndex].Value.ToString());

            ReclamacionesEN en = new ReclamacionesEN();
            en.Id = identi;

            bool borrado = en.borrarReclamacion();

            RellenarGridView();

            if (borrado)
            {
                Label1.Text = "¡Usuario borrado correctamente!";
            }
            else
            {
                Label2.Text = "¡ERROR al borrar el usuario!";
            }

        }
    }
}