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
    public class RegistroSaludDAO
    {
        public List<RegistroSalud> GetRegistros()
        {
            try
            {
                List<RegistroSalud> lst = new List<RegistroSalud>();
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;
                SqlConnection myConnection = new SqlConnection(con);
                SqlDataReader oDbDataReader = null;
                String queryString = oconf.GetRegistroSalud;
                //Abrimos conexión
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(queryString, myConnection);
                oDbDataReader = myCommand.ExecuteReader();
                while (oDbDataReader.Read())
                {
                    try
                    {
                        RegistroSalud oRegistro = new RegistroSalud();
                        oRegistro.IdRegistro = (int) oDbDataReader[0];
                        oRegistro.IdUsuario = (int) oDbDataReader[1];
                        oRegistro.IdEmpCampaña = (int) oDbDataReader[2];
                        oRegistro.Temperatura = (int) oDbDataReader[3];
                        oRegistro.TosSeca = (bool) oDbDataReader[4];
                        oRegistro.RespRapida = (bool) oDbDataReader[5];
                        oRegistro.FlemaAm = (bool) oDbDataReader[6];
                        oRegistro.Diftrag = (bool) oDbDataReader[7];
                        oRegistro.Cansfat = (bool) oDbDataReader[8];
                        oRegistro.Dolmus = (bool) oDbDataReader[9];
                        oRegistro.Doltor = (bool) oDbDataReader[10];
                        oRegistro.TestV = (bool) oDbDataReader[11];
                        oRegistro.Disfresp = (bool) oDbDataReader[12];

                        lst.Add(oRegistro);
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

        //Actualizar datos de un registro
        public bool SetCampaña(RegistroSalud RegistroSalud)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetRegistro, RegistroSalud.IdRegistro, RegistroSalud.IdUsuario, RegistroSalud.IdEmpCampaña, RegistroSalud.Temperatura, RegistroSalud.TosSeca, RegistroSalud.RespRapida, RegistroSalud.FlemaAm, RegistroSalud.Diftrag, RegistroSalud.Cansfat, RegistroSalud.Dolmus, RegistroSalud.Doltor, RegistroSalud.TestV, RegistroSalud.Disfresp);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }

        //Eliminar un registro por su id
        public bool DelCampaña(int idRegistro)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.DelRegistro, idRegistro);
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
