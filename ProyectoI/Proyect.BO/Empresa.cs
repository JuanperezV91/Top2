using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Empresa
    {
        int _idEmpresa;
        String _rutEmpresa;
        String _razonSocial;
        String _emailEmpresa;

        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string RutEmpresa { get => _rutEmpresa; set => _rutEmpresa = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string EmailEmpresa { get => _emailEmpresa; set => _emailEmpresa = value; }
    }
}
