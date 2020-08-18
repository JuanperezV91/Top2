using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Usuario
    {
        int _idUser;
        String _nombreUser;
        String _passUser;
        String _rutUser;
        String _apellidoPat;
        String _apellidoMat;
        String _email;
        String _rolUsuario;
        String _sexo;

        public string NombreUser { get => _nombreUser; set => _nombreUser = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string PassUser { get => _passUser; set => _passUser = value; }
        public string RutUser { get => _rutUser; set => _rutUser = value; }
        public string ApellidoPat { get => _apellidoPat; set => _apellidoPat = value; }
        public string ApellidoMat { get => _apellidoMat; set => _apellidoMat = value; }
        public string Email { get => _email; set => _email = value; }
        public string RolUsuario { get => _rolUsuario; set => _rolUsuario = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }
    }
}
