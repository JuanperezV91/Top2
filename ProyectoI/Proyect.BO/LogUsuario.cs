using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class LogUsuario
    {
        int idLog;
        int _idUsuario;
        DateTime _fechaRegistro;
        String _estadoSesion;

        Usuario usuario;


        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string EstadoSesion { get => _estadoSesion; set => _estadoSesion = value; }
        public int IdLog { get => idLog; set => idLog = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
    }
}
