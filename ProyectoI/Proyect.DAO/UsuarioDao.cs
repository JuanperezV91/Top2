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
    public class UsuarioDao
    {
        public List<Usuario> getUsuario()
        {
            List<Usuario> lst = new List<Usuario>();
            Usuario obj = new Usuario();

            //Conexion

            Config.Config oconf = new Config.Config();
            String con = oconf.con;

            SqlConnection myConnection = new SqlConnection(con);

            return lst;
        }

    }
}
