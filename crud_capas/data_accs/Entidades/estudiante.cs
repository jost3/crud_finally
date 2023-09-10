using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using data_accs.Conexion;

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
    }
}
