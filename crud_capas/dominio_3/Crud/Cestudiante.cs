using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data_accs.Entidades;
using capa_comm1.Atribut;

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

        public DataTable buscar(string buscar)
        {
            DataTable td = new DataTable();
            td = estudiante.buscar(buscar);
            return td;
        }

        public void insertar(atributesEstud obj)
        {
            estudiante.insertar(obj);
        }

        public void modificar(atributesEstud obj)
        {
            estudiante.modificar(obj);
        }
        public void eliminar(atributesEstud obj)
        {
            estudiante.eliminar(obj);
        }
    }
}
