using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrbaniaIntranet.Objetos;

namespace EvaluacionDocenteULSA
{
    public partial class _Default : Page
    {
        BDClass conn = new BDClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string a1 = Request.QueryString["a1"];
            string b1 = Request.QueryString["b1"];
            string c1 = Request.QueryString["c1"];
            string d1 = Request.QueryString["d1"];
            string e1 = Request.QueryString["e1"];
            string f1 = Request.QueryString["f1"];
            string g1 = Request.QueryString["g1"];
            string h1 = Request.QueryString["h1"];
            string h2 = Request.QueryString["h2"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = conn.login(Usuario.Value,Password.Value);

            if (id!="") {
                Session["id_alumno"] = id;
                Response.Redirect("Inicio");
            }


        }
    }
}