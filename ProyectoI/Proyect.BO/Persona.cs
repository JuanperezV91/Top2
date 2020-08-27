using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.BO
{
    public class Persona
    {
        int _idPersona;
        String _rutPersona;
        String _nombre;
        String _apellidoP;
        String _apellidoM;
        char _sexo;
        DateTime _fechaNac;
        String _email;

        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string RutPersona { get => _rutPersona; set => _rutPersona = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoP { get => _apellidoP; set => _apellidoP = value; }
        public string ApellidoM { get => _apellidoM; set => _apellidoM = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
