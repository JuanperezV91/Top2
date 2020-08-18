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
    public partial class ForgotPass : System.Web.UI.Page
    {
        Conf oconf = new Conf();
        Usuario usuario = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            String con = oconf.con;
            SqlConnection myConnection = new SqlConnection(con);
            usuario.Email = txtEmail.Text;

            String value = "select * from Usuarios where Email='" + usuario.Email + "'";

            SqlCommand mycommand = new SqlCommand(value, myConnection);
            myConnection.Open();

            SqlDataAdapter sda = new SqlDataAdapter(mycommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if(dataTable.Rows.Count != 0)
            {
                String myGUID = Guid.NewGuid().ToString();
                int IdUsuario = Convert.ToInt32(dataTable.Rows[0][0]);
                SqlCommand cmd = new SqlCommand("insert into RequestPass values('" + myGUID + "','" + IdUsuario + "',getDate())", myConnection);
                cmd.ExecuteNonQuery();

                //Enviar correo
                String DireccionEmail = dataTable.Rows[0][6].ToString();
                String NombreUsuario = dataTable.Rows[0][1].ToString();
                String CuerpoEmail = "Hola " + NombreUsuario + ", <br/><br/> Haga click en el siguiente link para ingresar una nueva contraseña <br/> http://localhost:59009/RecuperarPass.aspx?Uid="+ myGUID;
                MailMessage PassRecMail = new MailMessage("juanantonioperezveas@gmail.com", DireccionEmail);
                PassRecMail.Body = CuerpoEmail;
                PassRecMail.IsBodyHtml = true;
                PassRecMail.Subject = "Restablecer Contraseña";

                SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 587);
                SMTP.Credentials = new NetworkCredential()
                {
                    UserName = "juanantonioperezveas@gmail.com",
                    Password = "123"
                };
                SMTP.EnableSsl = true;
                SMTP.Send(PassRecMail);
                
                lblMsj.Text = "Revise su correo para restablecer su contraseña";
                lblMsj.ForeColor = Color.Green;
            }
            else
            {
                lblMsj.Text = "Ingresó un correo inválido";
                lblMsj.ForeColor = Color.Red;
            }
        }
    }
}