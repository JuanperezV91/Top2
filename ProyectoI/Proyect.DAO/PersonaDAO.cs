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
    public class PersonaDAO
    {

        public List<Persona> GetPersonas()
        {
            try
            {
                List<Persona> lst = new List<Persona>();
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
                        Persona oPersona = new Persona();

                        oPersona.IdPersona = (int)oDbDataReader[0];
                        oPersona.RutPersona = oDbDataReader[1].ToString();
                        oPersona.Nombre = oDbDataReader[2].ToString();
                        oPersona.ApellidoP = oDbDataReader[3].ToString();
                        oPersona.ApellidoM = oDbDataReader[4].ToString();
                        oPersona.Sexo = oDbDataReader[5].ToString();
                        oPersona.FechaNac = (DateTime) oDbDataReader[6];
                        oPersona.Email = oDbDataReader[7].ToString();


                        lst.Add(oPersona);
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

        public bool SetPersona(Persona Persona)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetPersona, Persona.IdPersona, Persona.RutPersona, Persona.Nombre, Persona.ApellidoP, Persona.ApellidoM, Persona.Sexo, Persona.FechaNac, Persona.Email);
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
