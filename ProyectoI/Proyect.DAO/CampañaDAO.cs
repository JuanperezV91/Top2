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
    public class CampañaDAO
    {
        public List <Campaña> GetCampañas()
        {
            try
            {
                List<Campaña> lst = new List<Campaña>();
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;
                SqlConnection myConnection = new SqlConnection(con);
                SqlDataReader oDbDataReader = null;

                String queryString = oconf.GetCampaña;
                //Abrimos conexión
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(queryString, myConnection);
                oDbDataReader = myCommand.ExecuteReader();
                while (oDbDataReader.Read())
                {
                    try
                    {
                        Campaña oCampaña = new Campaña();
                        oCampaña.IdCampaña = (int)oDbDataReader[0];
                        oCampaña.NombreCampaña = oDbDataReader[1].ToString();
                        oCampaña.EstadoCampaña = oDbDataReader[2].ToString();
                        oCampaña.InicioCampaña = (DateTime) oDbDataReader[3];
                        oCampaña.TerminoCampaña = (DateTime) oDbDataReader[4];

                        lst.Add(oCampaña);
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

        //Actualizar datos de una campaña
        public bool SetCampaña(Campaña Campaña)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetCampaña, Campaña.IdCampaña, Campaña.NombreCampaña, Campaña.EstadoCampaña, Campaña.InicioCampaña, Campaña.TerminoCampaña);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }

        //Eliminar una campaña por su id
        public bool DelCampaña(int idCampaña)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.DelCampaña, idCampaña);
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
