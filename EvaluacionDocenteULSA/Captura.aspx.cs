using EvaluacionDocenteULSA.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrbaniaIntranet.Objetos;

namespace EvaluacionDocenteULSA
{
    public partial class Captura : System.Web.UI.Page
    {
        string idpc = string.Empty, seccion = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] words = Session["valores"].ToString().Split('-');
            lblMaestro.Text = words[0];
            lblMateria.Text = words[1];

            if (Request["a1"] != null && Request["a1"] != "") {
                btnRegistrar_Click(null,null);
            }


        }
        BDClass conn = new BDClass();
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ObjResultado obj = new ObjResultado();
            string[] words = Session["valores"].ToString().Split('-');
            lblMaestro.Text = words[0];
            lblMateria.Text = words[1];
            idpc = words[2];
            seccion = words[3];
            obj.A1 = Request["a1"];
            obj.COMENTARIOA = Request["comentarioA"];
            obj.B1 = Request["b1"];
            obj.COMENTARIOB = Request["comentarioB"];
            obj.C1 = Request["c1"];
            obj.COMENTARIOC = Request["comentarioC"];
            obj.D1 = Request["d1"];
            obj.COMENTARIOD = Request["comentarioD"];
            obj.E1 = Request["e1"];
            obj.COMENTARIOE = Request["comentarioE"];
            obj.F1 = Request["f1"];
            obj.COMENTARIOF = Request["comentarioF"];
            obj.G1 = Request["g1"];
            obj.COMENTARIOG = Request["comentarioG"];
            obj.H1 = Request["h1"];
            obj.H2 = Request["h2"];
            obj.COMENTARIO  = Request["comentario"];
            obj.ID_ALUMNO = Session["id_alumno"].ToString();
            obj.ID_DOCENTE = words[4];
            obj.IDPC = idpc;
            obj.SECCION = seccion;
            int valid = conn.insEvaluacion(obj);
            if (valid == 1)
            {
                Response.Redirect("Inicio");
            }
            else {

            }



        }
    }
}