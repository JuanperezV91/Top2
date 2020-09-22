using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class RegistroS
    {
        int _idRegistro;
        int _idUsuario;
        int _temperatura;
        String _tosSeca;
        String _respRapida;
        String _flemaAm;
        String _diftrag;
        String _cansfat;
        String _dolmus;
        String _doltor;
        String _testV;
        String _disfresp;
        int _idEmpleado;

        Usuario _usuario;
        EmpleadoCampaña _empCampaña;


        public int IdRegistro { get => _idRegistro; set => _idRegistro = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int Temperatura { get => _temperatura; set => _temperatura = value; }
        public string TosSeca { get => _tosSeca; set => _tosSeca = value; }
        public string RespRapida { get => _respRapida; set => _respRapida = value; }
        public string FlemaAm { get => _flemaAm; set => _flemaAm = value; }
        public string Diftrag { get => _diftrag; set => _diftrag = value; }
        public string Cansfat { get => _cansfat; set => _cansfat = value; }
        public string Dolmus { get => _dolmus; set => _dolmus = value; }
        public string Doltor { get => _doltor; set => _doltor = value; }
        public string TestV { get => _testV; set => _testV = value; }
        public string Disfresp { get => _disfresp; set => _disfresp = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }

        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public EmpleadoCampaña EmpCampaña { get => _empCampaña; set => _empCampaña = value; }
    }
}
