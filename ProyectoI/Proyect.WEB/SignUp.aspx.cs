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
    public partial class SignUp : System.Web.UI.Page
    {
        ConexionDao conexion = new ConexionDao();
        Usuario usuario = new Usuario();
        Conf oconf = new Conf();

        int idValue;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String con = oconf.con;
            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            String idPersona = oconf.SignPersona;
            String idUsuario = oconf.SignUser;

            //Persona
            SqlDataAdapter sds = new SqlDataAdapter(idPersona, con);
            DataTable dt = new DataTable();
            sds.Fill(dt);
            txtIdPersona.Text = dt.Rows[0][0].ToString();

            //Usuario
            SqlDataAdapter sdu = new SqlDataAdapter(idUsuario, con);
            DataTable du = new DataTable();
            sdu.Fill(du);
            txtIdUser.Text = du.Rows[0][0].ToString();


            usuario.NombreUser = txtNomUsuario.Text;
            usuario.PassUser = txtPass.Text;
            usuario.RutUser = txtRut.Text;
            usuario.ApellidoPat = txtApPaterno.Text;
            usuario.ApellidoMat = txtApMaterno.Text;
            usuario.Email = txtEmail.Text;
            usuario.RolUsuario = txtRol.Text;
            usuario.Sexo = txtSexo.Text;
            String dateTemp = "";
       

            if (txtNomUsuario.Text!="" && txtPass.Text != "" && txtRut.Text != "" && txtApPaterno.Text != "" && txtApMaterno.Text != "" && txtEmail.Text != "" && txtRol.Text != "" )
            {
                if(txtPass.Text == txtCPass.Text)
                {
                  

                    //Registro Persona
                    String value2 = "insert into Persona values('" + txtIdPersona.Text + "','" + usuario.RutUser + "','" + usuario.NombreUser + "','" + usuario.ApellidoPat + "','" + usuario.ApellidoMat + "','" + usuario.Sexo + "','"+dateTemp+ "','" + usuario.Email + "')";
                    conexion.RegistroUsuario(value2); // Llamamos al metodo que inserta nuevo usuario


                    String value = "insert into Usuario values('" + txtIdUser.Text + "','" + usuario.NombreUser + "','" + usuario.PassUser + "','" + usuario.RolUsuario + "','" + txtIdPersona.Text + "')";
                    conexion.RegistroUsuario(value); // Llamamos al metodo que inserta nuevo usuario

                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "Registro exitoso";
                }
                else
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Las contraseñas no coinciden";
                }
             
            }
            else
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Rellene los campos requeridos";
            }
            

        }
    }
}