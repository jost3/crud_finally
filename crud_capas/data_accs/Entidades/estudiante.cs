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
                cmd.CommandText = "SP_mostrar";
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

        public DataTable buscar(string buscar)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", buscar);
                dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                td.Load(dr);
            }
            catch (Exception ex)
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
                cmd.CommandText = "SP_insertar";
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

        public void modificar(atributesEstud obj)
        {
            try
            {
                //iINSERTAR DATOS CONFUCION AL CREAR EL PROCEDIMIENRTO ALMACENADO
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_modificar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@sexo", obj.Sexo);
                cmd.Parameters.AddWithValue("@dni", obj.Dni);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                string smg = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void eliminar(atributesEstud obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_eliminar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                string sbj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

    }
}
