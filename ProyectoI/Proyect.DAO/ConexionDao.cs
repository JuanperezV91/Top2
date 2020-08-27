using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proyect.BO;
using System.Data;




namespace Proyect.DAO
{
    public class ConexionDAO
    {
        static String config;
        int idLogCount;

        public static string Config { get => config; set => config = value; }
        public int IdLogCount { get => idLogCount; set => idLogCount = value; }

        public void ConexionRegistrar()
        {
            Config.Config oconf = new Config.Config();
            config = oconf.con;

            SqlConnection myConnection = new SqlConnection(config);
            String queryRegistro = oconf.Registro;
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryRegistro, myConnection);
            SqlDataReader oDbDataReader = null;
            oDbDataReader = mycommand.ExecuteReader();//Obtenemos el resultado de la consulta insertar nuevo usuario
        }

        public void RegistroUsuario(String insertValue)
        {
            Config.Conf oconf = new Config.Conf();
            String con = oconf.con;

            //Establecer conexion con la BD

            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            //Conexion Establecida

            //Insert values
            SqlCommand mycommand = new SqlCommand(insertValue, myConnection);
            mycommand.ExecuteNonQuery();
            SqlDataReader oDbDataReader = null;
           // oDbDataReader = mycommand.ExecuteReader();//Obtenemos el resultado de la consulta insertar nuevo usuario
        }

        public void RegistroLog(String insertValue)
        {
            Config.Conf oconf = new Config.Conf();
            String con = oconf.con;

            //Establecer conexion con la BD

            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            //Conexion Establecida

            //Insert values
            SqlCommand mycommand = new SqlCommand(insertValue, myConnection);
            mycommand.ExecuteNonQuery();
            SqlDataReader oDbDataReader = null;
            // oDbDataReader = mycommand.ExecuteReader();//Obtenemos el resultado de la consulta insertar nuevo usuario
        }

        public string ObtenerId(string SQLIns)
        {
            try
            {
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;

                //Establecer conexion con la BD

                SqlConnection myConnection = new SqlConnection(con);
                myConnection.Open();
                DataTable consulta = new DataTable();
                string stConsulta;

                SqlDataAdapter ConsultaAdapter = new SqlDataAdapter(SQLIns, con);
                ConsultaAdapter.Fill(consulta);
                foreach (DataRow myrow in consulta.Rows)
                {
                    stConsulta = Convert.ToString(myrow[0]);
                    return stConsulta;
                }
            }
            catch
            {
                throw;
            }
            return "0";
        }
        public void Ejecutar(string SQLIns)
        {
            try
            {
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;

                //Establecer conexion con la BD

                SqlConnection myConnection = new SqlConnection(con);
                myConnection.Open();
                DataTable consulta = new DataTable();
                SqlDataAdapter ConsultaAdapter = new SqlDataAdapter(SQLIns, con);
                ConsultaAdapter.Fill(consulta);
            }
            catch
            {
                throw;
            }
        }

        public void LoginUsuario(String insertValue)
        {
            Config.Conf oconf = new Config.Conf();
            String con = oconf.con;

            //Establecer conexion con la BD

            SqlConnection myConnection = new SqlConnection(con);
            myConnection.Open();

            //Conexion Establecida

            
            SqlCommand mycommand = new SqlCommand(insertValue, myConnection);
            mycommand.ExecuteNonQuery();
            // SqlDataReader oDbDataReader = null;
            // oDbDataReader = mycommand.ExecuteReader();//Obtenemos el resultado de la consulta insertar nuevo usuario
            SqlDataAdapter sda = new SqlDataAdapter(mycommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows.Count != 0)
            {
                //Response.Redirect("");
            }
        }
    }
}