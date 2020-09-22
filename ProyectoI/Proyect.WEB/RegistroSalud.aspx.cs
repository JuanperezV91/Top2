using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using Proyect.DAO;
using Proyect.BO;
using System.Drawing;
using Proyect.DAO.Config;
using System.Data;

namespace Proyect.WEB
{
    public partial class RegistroSalud : System.Web.UI.Page
    {
        public string idUser_;
        public int idEmpleado_;
        Conf oconf = new Conf();
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RegistroSaludDAO dao = new RegistroSaludDAO();
             //   idEmpleado_ = (int) Session["IDEMPLEADO"];
              
            }
            idUser_ = (string)Session["IDUSUARIOACTUAL"];
            txtNombre.Text = (string)Session["NOMBREEMPLEADO"];
        }

        protected void buttonRegistro_Salud(object sender, EventArgs e)
        {
            String con = oconf.con;
            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            String idRegS = oconf.signRegS;
            SqlDataAdapter sds = new SqlDataAdapter(idRegS, con);
            DataTable dt = new DataTable();
            sds.Fill(dt);

            RegistroSaludDAO dao = new RegistroSaludDAO();
            RegistroS obj = new RegistroS();

            obj.IdRegistro = (int)dt.Rows[0][0];
            obj.IdUsuario = int.Parse(idUser_);
            obj.Temperatura = int.Parse(txttemperatura.Text);
                                 
           
            if (chkTosSec.Checked == true)
            {
                obj.TosSeca = "SI";
            }
            else
            {
                obj.TosSeca = "NO";
            }

            if(chkDifRes.Checked == true)
            {
               obj.Disfresp = "SI";
            }
            else
            {
                obj.Disfresp = "NO";
            }

            if (chkRespRa.Checked == true)
            {
               obj.RespRapida = "SI";
            }
            else
            {
                obj.RespRapida = "NO";
            }

            if (chkFle.Checked == true)
            {
                obj.FlemaAm = "SI";
            }
            else
            {
                obj.FlemaAm = "NO";
            }

            if (chkDif.Checked == true)
            {
                obj.Diftrag = "SI";
            }
            else
            {
                obj.Diftrag = "NO";
            }

            if (chkCansf.Checked == true)
            {
                obj.Cansfat = "SI";
            }
            else
            {
                obj.Cansfat = "NO";
            }

            if (chkDolms.Checked == true)
            {
                obj.Dolmus = "SI";
            }
            else
            {
                obj.Dolmus = "NO";
            }

            if (chkDolts.Checked == true)
            {
                obj.Doltor = "SI";
            }
            else
            {
                obj.Doltor = "NO";
            }

            if (chkTest.Checked == true)
            {
                obj.TestV = "SI";
            }
            else
            {
                obj.TestV = "NO";
            }

            obj.IdEmpleado = idEmpleado_;

            if (dao.SetRegistroS(obj))
            {
                Response.Redirect("~/VerEmpleados.aspx");
            }

        }
    }
}