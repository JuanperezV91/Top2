using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Campaña
    {
        int _idCampaña;
        String _nombreCampaña;
        String _estadoCampaña;
        DateTime _inicioCampaña;
        DateTime _terminoCampaña;

        public int IdCampaña { get => _idCampaña; set => _idCampaña = value; }
        public string NombreCampaña { get => _nombreCampaña; set => _nombreCampaña = value; }
        public string EstadoCampaña { get => _estadoCampaña; set => _estadoCampaña = value; }
        public DateTime InicioCampaña { get => _inicioCampaña; set => _inicioCampaña = value; }
        public DateTime TerminoCampaña { get => _terminoCampaña; set => _terminoCampaña = value; }
    }
}
