using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrbaniaIntranet.Objetos;

namespace EvaluacionDocenteULSA
{
    public partial class Inicio : System.Web.UI.Page
    {
        BDClass conn = new BDClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtMaestros = conn.cargaMaestros(Session["id_alumno"].ToString());
            if (!IsPostBack)
            {
                cmbx_maestros.DataTextField = "DISPLAY";
                cmbx_maestros.DataValueField = "DISPLAY";
                cmbx_maestros.DataSource = dtMaestros;
                cmbx_maestros.DataBind();
            }

            }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            Session["valores"] = cmbx_maestros.SelectedValue;
            Response.Redirect("Captura");
        }
    }
}