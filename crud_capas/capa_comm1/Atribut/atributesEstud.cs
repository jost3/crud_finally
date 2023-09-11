using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_comm1.Atribut
{
    public class atributesEstud
    {
        private int iD;
        private string nombre;
        private string apellido;
        private string sexo;
        private int dni;

        public int ID { get => iD; set => iD = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
