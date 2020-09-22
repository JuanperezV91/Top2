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
    public partial class RegistrarEmpleado : System.Web.UI.Page
    {
        public static int idEmpleado;
        Conf oconf = new Conf();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EmpleadoDAO dao = new EmpleadoDAO();
               
            }
        }

        protected void RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            String con = oconf.con;
            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            String idPersona = oconf.SignPersona;
            SqlDataAdapter sds = new SqlDataAdapter(idPersona, con);
            DataTable dt = new DataTable();
            sds.Fill(dt);

            String idEmpleado = oconf.signEmpleado;
            SqlDataAdapter sde = new SqlDataAdapter(idEmpleado, con);
            DataTable de = new DataTable();
            sde.Fill(de);
            
            //txtIdEmpleado.Text = dt.Rows[0][0].ToString();

            //Empleado
            EmpleadoDAO dao = new EmpleadoDAO();
            Empleado obj = new Empleado();
            //Persona
            PersonaDAO daoPersona = new PersonaDAO();
            Persona objPersona = new Persona();
            String dateTemp = "";

            int personaId;

            //Agregar Persona
            objPersona.IdPersona = (int) dt.Rows[0][0];
            objPersona.RutPersona = txtRut.Text;
            objPersona.Nombre = txtNomUsuario.Text;
            objPersona.ApellidoP = txtApPaterno.Text;
            objPersona.ApellidoM = txtApMaterno.Text;
            //  objPersona.id = objPersona.IdPersona;
            objPersona.IdPersonas = objPersona.IdPersona;

            if (rbtnHombre.Checked == true)
            {
                objPersona.Sexo = "Hombre";
            }

            if (rbtnMujer.Checked == true)
            {
                objPersona.Sexo = "Mujer";
            }

            objPersona.FechaNac = DateBirth.TodaysDate;
            objPersona.Email = txtEmail.Text;
          

            //Agregar Empleado
            obj.IdEmpleado = (int) de.Rows[0][0];
            obj.IdPersona = objPersona.IdPersonas;
            obj.Cargo = txtCargo.Text;
            obj.Area = txtArea.Text;
            obj.NombreEmpresa = txtEmpresa.Text;

            if (daoPersona.SetPersona(objPersona))
            {
                txtRut.Text = "";
                txtApPaterno.Text = "";
                txtApMaterno.Text = "";
                txtEmail.Text = "";
            }

            if (dao.SetEmpleado(obj))
            {
                txtCargo.Text = "";
                txtArea.Text = "";
                txtEmpresa.Text = "";
            }

            Response.Redirect("~/VerEmpleados.aspx");




        }
    }
}