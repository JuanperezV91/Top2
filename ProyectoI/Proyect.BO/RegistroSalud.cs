using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class RegistroSalud
    {
        int _idRegistro;
        int _idUsuario;
        int _idEmpCampaña;
        int _temperatura;
        Boolean _tosSeca;
        Boolean _respRapida;
        Boolean _flemaAm;
        Boolean _diftrag;
        Boolean _cansfat;
        Boolean _dolmus;
        Boolean _doltor;
        Boolean _testV;
        Boolean _disfresp;

        Usuario _usuario;
        EmpleadoCampaña _empCampaña;


        public int IdRegistro { get => _idRegistro; set => _idRegistro = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdEmpCampaña { get => _idEmpCampaña; set => _idEmpCampaña = value; }
        public int Temperatura { get => _temperatura; set => _temperatura = value; }
        public bool TosSeca { get => _tosSeca; set => _tosSeca = value; }
        public bool RespRapida { get => _respRapida; set => _respRapida = value; }
        public bool FlemaAm { get => _flemaAm; set => _flemaAm = value; }
        public bool Diftrag { get => _diftrag; set => _diftrag = value; }
        public bool Cansfat { get => _cansfat; set => _cansfat = value; }
        public bool Dolmus { get => _dolmus; set => _dolmus = value; }
        public bool Doltor { get => _doltor; set => _doltor = value; }
        public bool TestV { get => _testV; set => _testV = value; }
        public bool Disfresp { get => _disfresp; set => _disfresp = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public EmpleadoCampaña EmpCampaña { get => _empCampaña; set => _empCampaña = value; }
    }
}
