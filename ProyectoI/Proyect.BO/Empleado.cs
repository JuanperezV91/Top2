using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Empleado
    {
        int _idEmpleado;
        int _idPersona;
        String _nombreEmpresa;
        String _cargo;
        String _area;

        

        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public string Area { get => _area; set => _area = value; }
        public string NombreEmpresa { get => _nombreEmpresa; set => _nombreEmpresa = value; }
    }
}
