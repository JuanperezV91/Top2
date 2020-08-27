using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class EmpleadoCampaña
    {
        int _idEmpCampaña;
        int _idEmpleado;
        int _idCampaña;
        DateTime _fechaRegistro;

        Empleado _empleado;
        Campaña _campaña;

        public int IdEmpCampaña { get => _idEmpCampaña; set => _idEmpCampaña = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int IdCampaña { get => _idCampaña; set => _idCampaña = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }
        public Campaña Campaña { get => _campaña; set => _campaña = value; }
    }
}
