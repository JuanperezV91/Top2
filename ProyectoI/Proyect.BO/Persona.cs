using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Persona
    {
        int idPersonas;

        int _idPersona;
        String _rutPersona;
        String _nombre;
        String _apellidoP;
        String _apellidoM;
        String _sexo;
        DateTime _fechaNac;
        String _email;

        public int IdPersonas { get => idPersonas; set => idPersonas = value; }
        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string RutPersona { get => _rutPersona; set => _rutPersona = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoP { get => _apellidoP; set => _apellidoP = value; }
        public string ApellidoM { get => _apellidoM; set => _apellidoM = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public string Email { get => _email; set => _email = value; }

        public bool valRut(string rut)
        {
            bool flag = true;
            return flag;
        }
    }
}
