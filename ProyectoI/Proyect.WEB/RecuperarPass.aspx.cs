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
using System.Net.Mail;
using System.Net;


namespace Proyect.WEB
{
    public partial class RecuperarPass : System.Web.UI.Page
    {
        Conf oconf = new Conf();
        Usuario usuario = new Usuario();
        String CS = ConfigurationManager.ConnectionStrings["ProyectoBDConnectionString"].ConnectionString;
        String GUIDvalue;

        int Uid;

        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPassword.Visible = false;
            txtCPassword.Visible = false;
            btnRestablecer.Visible = false;

            using (SqlConnection con = new SqlConnection(CS))
            {
                GUIDvalue = Request.QueryString["Uid"];
                if (GUIDvalue != null)
                {
                    SqlCommand cmd = new SqlCommand("select * from RequestPass where IdRequest='" + GUIDvalue + "'", con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        Uid = Convert.ToInt32(dt.Rows[0][1]); //IdUsuario - RequestPass
                    }
                    else
                    {
                        lblMsj.Text = "El link de restauración de contraseña expiró o es inválido";
                        lblMsj.ForeColor = Color.Red;
                    }
                }
                else
                {
                    Response.Redirect("~/AdminPage.aspx");
                }
            }

            if (!IsPostBack)
            {
                if (dt.Rows.Count != 0)
                {
                    txtPassword.Visible = true;
                    txtCPassword.Visible = true;
                    btnRestablecer.Visible = true;
                    
                }
                else
                {
                    lblMsj.Text = "El link de restauración de contraseña expiró o es inválido";
                    lblMsj.ForeColor = Color.Red;
                }
            }
          
        }

        protected void btnRestablecer_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtCPassword.Text!= "" && txtPassword.Text == txtCPassword.Text)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("update Usuario set PassUsuario='" + txtCPassword.Text + "' where IdUsuario='" + Uid + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("delete from RequestPass where IdUsuario='" + Uid + "'", con); //Eliminamos el link de restauración
                    cmd2.ExecuteNonQuery();
                    Response.Redirect("~/Login.aspx");

                }
            }
           

        }
    }
}