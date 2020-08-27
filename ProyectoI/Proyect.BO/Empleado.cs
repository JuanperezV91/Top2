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
        int _idEmpresa;
        String _cargo;
        String _area;

        Persona _persona;
        Empresa _empresa;

        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public string Area { get => _area; set => _area = value; }
        internal Persona Persona { get => _persona; set => _persona = value; }
        internal Empresa Empresa { get => _empresa; set => _empresa = value; }
    }
}
