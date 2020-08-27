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
    public class EmpresaDAO
    {
        public List<Empresa> GetEmpresas()
        {
            try
            {
                List<Empresa> lst = new List<Empresa>();
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;
                SqlConnection myConnection = new SqlConnection(con);
                SqlDataReader oDbDataReader = null;
                String queryString = oconf.GetEmpresa;
                //Abrimos conexión
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(queryString, myConnection);

                oDbDataReader = myCommand.ExecuteReader();
                while (oDbDataReader.Read())
                {
                    try
                    {
                        Empresa oEmpresa = new Empresa();
                        oEmpresa.IdEmpresa = (int)oDbDataReader[0];
                        oEmpresa.RutEmpresa = oDbDataReader[1].ToString();
                        oEmpresa.RazonSocial = oDbDataReader[2].ToString();
                        oEmpresa.EmailEmpresa = oDbDataReader[3].ToString();

                        lst.Add(oEmpresa);
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
        
        //Actualizar datos de una empresa
        public bool SetEmpresa(Empresa Empresa)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetEmpresa, Empresa.IdEmpresa, Empresa.RutEmpresa, Empresa.RazonSocial, Empresa.EmailEmpresa);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }

        //Eliminar una empresa por su rut
        public bool DelEmpresa(String rut)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.DelEmpresa, rut);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
