using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using data_accs.Conexion;
using capa_comm1.Atribut;

namespace data_accs.Entidades
{
    public class estudiante
    {
        //variables
        conexion_BD c = new conexion_BD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();

        public DataTable Mostrar() 
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "sp_mostrar";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
            catch(Exception ex)
            {
                string smj = ex.ToString();

            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }
        public void insertar(atributesEstud obj)
        {
            try
            {
                //iINSERTAR DATOS CONFUCION AL CREAR EL PROCEDIMIENRTO ALMACENADO
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "mostrar1";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID",obj.ID);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@sexo", obj.Sexo);
                cmd.Parameters.AddWithValue("@dni", obj.Dni);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }
            catch(Exception ex)
            {
                string smg = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }
    }
}
