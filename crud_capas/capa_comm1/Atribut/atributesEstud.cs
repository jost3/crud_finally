using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_comm1.Atribut
{
    public class atributesEstud
    {
        private string ID;
        private string nombre;
        private string apellido;
        private string sexo;
        private char dni;

        public string ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public char Dni { get => dni; set => dni = value; }
    }
}
