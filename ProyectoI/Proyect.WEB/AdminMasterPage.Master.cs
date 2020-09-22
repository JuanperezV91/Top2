using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Proyect.DAO;
using Proyect.BO;
using System.Drawing;
using Proyect.DAO.Config;
using System.Data;

namespace Proyect.WEB
{
    public partial class AdminMasterPage : System.Web.UI.MasterPage
    {
        ConexionDAO conexion = new ConexionDAO();
        Conf oconf = new Conf();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERNAME"] != null)
                {
                    lblMsj.Text = "Bienvenido " + Session["USERNAME"].ToString() + "";
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnSignOut_Click2(object sender, EventArgs e)
        {
            String con = oconf.con;
            String log = oconf.log;
            String EstadoConexion = "Sesión Cerrada";
            SqlDataAdapter sds = new SqlDataAdapter(log, con);
            DataTable dt = new DataTable();
            sds.Fill(dt);
            txtIdLog.Text = dt.Rows[0][0].ToString();

            //Ingresar datos a la tabla log
            string value2 = "insert into Logs values('" + txtIdLog.Text + "','" + Login.idUsers.ToString() + "','" + DateTime.Now + "','" + EstadoConexion + "')";
            conexion.RegistroLog(value2); // Llamamos al metodo que inserta nuevo log          

            Session.Remove("USERNAME");
            Session["USERNAME"] = null;
            Response.Redirect("~/Login.aspx");
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrarUsuario.aspx");

        }

        protected void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrarEmpleado.aspx");

        }
    }
}