using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data_accs.Entidades;

namespace dominio_3.Crud
{
    public class Cestudiante
    {
        estudiante estudiante = new estudiante();

        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = estudiante.Mostrar();
            return td;
        }
    }
}
