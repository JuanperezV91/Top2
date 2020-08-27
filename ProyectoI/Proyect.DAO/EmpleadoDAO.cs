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
    public class EmpleadoDAO
    {
        public List<Empleado> GetEmpleados()
        {
            try
            {
                List<Empleado> lst = new List<Empleado>();
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;
                SqlConnection myConnection = new SqlConnection(con);
                SqlDataReader oDbDataReader = null;
                String queryString = oconf.GetEmpleado;
                //Abrimos conexión
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(queryString, myConnection);
                oDbDataReader = myCommand.ExecuteReader();
                while (oDbDataReader.Read())
                {
                    try
                    {
                        Empleado oEmpleado = new Empleado();
                        
                        oEmpleado.IdEmpleado = (int)oDbDataReader[0];
                        oEmpleado.IdPersona = (int)oDbDataReader[1];
                        oEmpleado.IdEmpresa = (int)oDbDataReader[2];
                        oEmpleado.Cargo = oDbDataReader[2].ToString();
                        oEmpleado.Area = oDbDataReader[3].ToString();

                        lst.Add(oEmpleado);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }

                return lst;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SetEmpleado(Empleado Empleado)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetEmpleado, Empleado.IdEmpleado, Empleado.IdPersona, Empleado.IdEmpresa, Empleado.Cargo, Empleado.Area);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }

        /*
        public bool DelEmpleado(String rut)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.DelEmpleado, rut);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }*/
    }
}
