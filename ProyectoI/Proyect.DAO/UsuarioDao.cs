using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyect.BO;
using System.Data.SqlClient;
using System.Data;

namespace Proyect.DAO
{
    public class UsuarioDAO
    {
        public List<Usuario> GetUsuarios()
        {
            try
            {
                List<Usuario> lst = new List<Usuario>();
                Config.Conf oconf = new Config.Conf();
                String con = oconf.con;
                SqlConnection myConnection = new SqlConnection(con);
                SqlDataReader oDbDataReader = null;
                String queryString = oconf.GetUsuarios;
                //Abrimos conexión
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(queryString, myConnection);
                oDbDataReader = myCommand.ExecuteReader();
                while (oDbDataReader.Read())
                {
                    try
                    {
                        Usuario oUsuario = new Usuario();
                        oUsuario.IdUser = (int)oDbDataReader[0];
                        oUsuario.NombreUser = oDbDataReader[1].ToString();
                        oUsuario.PassUser = oDbDataReader[2].ToString();
                        oUsuario.RolUsuario = oDbDataReader[3].ToString();
                        oUsuario.IdPersona = (int)oDbDataReader[4];

                        lst.Add(oUsuario);
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
        //Actualizar datos de un usuario
        public bool SetUsuario(Usuario Usuario)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.SetUsuario, Usuario.IdUser, Usuario.NombreUser, Usuario.PassUser, Usuario.RolUsuario, Usuario.IdPersona);
            myConnection.Open();
            SqlCommand mycommand = new SqlCommand(queryString, myConnection);
            oDbDataReader = mycommand.ExecuteReader();
            if (oDbDataReader.RecordsAffected > 0)
            {
                flag = true;
            }
            return flag;
        }

        //Eliminar un usuario por su id
        public bool DelUsuario(int idUsuario)
        {
            bool flag = false;
            Config.Conf oConfig = new Config.Conf();
            String con = oConfig.con;
            SqlConnection myConnection = new SqlConnection(con);
            SqlDataReader oDbDataReader = null;
            String queryString = String.Format(oConfig.DelUsuario, idUsuario);
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
