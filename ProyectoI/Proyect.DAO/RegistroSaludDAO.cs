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
        public List<RegistroS> GetRegistros()
        {
            try
            {
                List<RegistroS> lst = new List<RegistroS>();
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
                        RegistroS oRegistro = new RegistroS();
                        oRegistro.IdRegistro = (int) oDbDataReader[0];
                        oRegistro.IdUsuario = (int) oDbDataReader[1];
                        oRegistro.Temperatura = (int) oDbDataReader[2];
                        oRegistro.TosSeca = oDbDataReader[3].ToString();
                        oRegistro.RespRapida = oDbDataReader[4].ToString();
                        oRegistro.FlemaAm = oDbDataReader[5].ToString();
                        oRegistro.Diftrag = oDbDataReader[6].ToString();
                        oRegistro.Cansfat = oDbDataReader[7].ToString();
                        oRegistro.Dolmus = oDbDataReader[8].ToString();
                        oRegistro.Doltor = oDbDataReader[9].ToString();
                        oRegistro.TestV =  oDbDataReader[10].ToString();
                        oRegistro.Disfresp = oDbDataReader[11].ToString();
                        oRegistro.IdEmpleado = (int) oDbDataReader[12];


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
        public bool SetRegistroS(RegistroS RegistroSalud)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetRegistro, RegistroSalud.IdRegistro, RegistroSalud.IdUsuario, RegistroSalud.Temperatura, RegistroSalud.TosSeca, RegistroSalud.RespRapida, RegistroSalud.FlemaAm, RegistroSalud.Diftrag, RegistroSalud.Cansfat, RegistroSalud.Dolmus, RegistroSalud.Doltor, RegistroSalud.TestV, RegistroSalud.Disfresp, RegistroSalud.IdEmpleado);
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
        public bool DelRegistroS(int idRegistro)
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
