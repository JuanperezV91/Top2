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
    public partial class Login : System.Web.UI.Page
    {
        public static string sUsername;
        public static string sUserPass;
        public static string idUsers;
        int idLog;

        ConexionDao conexion = new ConexionDao();
        Usuario usuario = new Usuario();
        LogUsuario log = new LogUsuario();
        Conf oconf = new Conf();
        public static int IdLogValue;
       // Config.Conf conf = new Config.Conf();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (!IsPostBack)
            {
                if(Request.Cookies["UsuarioCookies"]!=null && Request.Cookies["PasswordCookies"] != null)
                {
                    txtUsername.Text = Request.Cookies["UsuarioCookies"].Value;
                    txtPassword.Attributes["value"] = Request.Cookies["PasswordCookies"].Value;
                    ChkSession.Checked = true;
                }
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String EstadoConexion;
            String con = oconf.con;
            SqlConnection myConnection = new SqlConnection(con);
            usuario.NombreUser = txtUsername.Text;
            usuario.PassUser = txtPassword.Text;
            //Conexion Establecida


            sUsername = usuario.NombreUser;
            sUserPass = usuario.PassUser;
          //  log.Usuario.IdUser = usuario.IdUser;
            String value = "select * from Usuario where NombreUsuario='" + usuario.NombreUser + "' and PassUsuario='" + usuario.PassUser + "'";

            SqlCommand mycommand = new SqlCommand(value, myConnection);
            myConnection.Open();

            SqlDataAdapter sda = new SqlDataAdapter(mycommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows.Count != 0)
            {
                if (ChkSession.Checked)
                {
                    //Cookies
                    Response.Cookies["UsuarioCookies"].Value = usuario.NombreUser;
                    Response.Cookies["PasswordCookies"].Value = usuario.PassUser;
                    //Time Cookies
                    Response.Cookies["UsuarioCookies"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["PasswordCookies"].Expires = DateTime.Now.AddDays(15);                                 
                }
                else
                {
                    //Time Cookies
                    Response.Cookies["UsuarioCookies"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["PasswordCookies"].Expires = DateTime.Now.AddDays(-1);
                }

                string UserType;
                String log = oconf.log;

                UserType = dataTable.Rows[0][3].ToString();
                ;

                ConexionDao dao = new ConexionDao();

                if (UserType == "Admin")
                {
                   
                    IdLogValue += 1;
                    dao.IdLogCount = IdLogValue;
                    EstadoConexion = "Sesión Iniciada";

                    foreach (DataRow myrow in dataTable.Rows)
                    {
                        idUsers = Convert.ToString(myrow[0]);
                    }

                    SqlDataAdapter sds = new SqlDataAdapter(log, con);
                    DataTable dt = new DataTable();
                    sds.Fill(dt);
                    txtIdLog.Text = dt.Rows[0][0].ToString();

                    //Ingresar datos a la tabla log
                    //  string value2 = "insert into Log values('" + dao.IdLogCount + "','" + idUsers + "','" + DateTime.Now + "','" + EstadoConexion + "')";
                    string value2 = "insert into Logs values('" + txtIdLog.Text + "','" + idUsers + "','" + DateTime.Now + "','" + EstadoConexion + "')";

                    conexion.RegistroLog(value2); // Llamamos al metodo que inserta nuevo log


                    Session["USERNAME"] = usuario.NombreUser;
                    Response.Redirect("~/AdminPage.aspx");            
                   
                }

                if (UserType == "User")
                {
                    EstadoConexion = "Sesión Iniciada";
                    IdLogValue += 1;
                    dao.IdLogCount = IdLogValue;

                    foreach (DataRow myrow in dataTable.Rows)
                    {
                        idUsers = Convert.ToString(myrow[0]);
                    }

                    SqlDataAdapter sds = new SqlDataAdapter(log, con);
                    DataTable dt = new DataTable();
                    sds.Fill(dt);
                    txtIdLog.Text = dt.Rows[0][0].ToString();

                    //Ingresar datos a la tabla log
                    string value2 = "insert into Logs values('" + txtIdLog.Text + "','" + idUsers + "','" + DateTime.Now + "','" + EstadoConexion + "')";
                    conexion.RegistroLog(value2); // Llamamos al metodo que inserta nuevo log

                    Session["USERNAME"] = usuario.NombreUser;
                    Response.Redirect("~/UserPage.aspx");          

                }

            }
            else
            {             
                Response.Redirect("~/Login.aspx");
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Usuario o Password Inválida";                              
            }
            // lblMsj.ForeColor = Color.Green;
            //lblMsj.Text = "Registro exitoso";
        }
    }
}