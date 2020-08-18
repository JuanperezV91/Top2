using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyect.WEB
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERNAME"] != null)
                {
                    lblMsj.Text = "Acceso exitoso, Bienvenido " + Session["USERNAME"].ToString() + "";
                }
            }
            catch(Exception ex)
            {
                Response.Redirect("~/Login.aspx");
            }

            /*
                if(Session["USERNAME"] != null)
            {
                lblMsj.Text = "Acceso exitoso, Bienvenido " + Session["USERNAME"].ToString()+"";
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
             */
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session.Remove("USERNAME");
            Session["USERNAME"] = null;
            Response.Redirect("~/Login.aspx");

        }
    }
}