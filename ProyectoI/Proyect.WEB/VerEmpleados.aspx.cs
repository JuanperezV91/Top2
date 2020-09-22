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
    public partial class VerEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpleadoDAO dao = new EmpleadoDAO();
           

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["RUTEMPLEADO"] = GridView1.SelectedRow.Cells[1].Text;
            Session["NOMBREEMPLEADO"] = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void RegistroSalud(object sender, GridViewCommandEventArgs e)
        {
            Response.Redirect("~/RegistroSalud.aspx");
        }
    }
}