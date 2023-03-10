using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Entidades;
using DatosORM;
using System.Data.EntityClient;


namespace Datos
{
    public class MetodosData
    {
//        public static DataTable EjecutarComandoProc(DbCommand comando)
//        {
//            using (Navitur1Entities Contexto = new Navitur1Entities())
//            {
//                var dt = new DataTable();
             
//                var conn = Contexto.Database.Connection;
//                var connectionState = conn.State;

//                try
//                {
//                    if (connectionState != ConnectionState.Open) conn.Open();
//                    comando = conn.CreateCommand();
                    

//                    using (var cmd = conn.CreateCommand())
//                    {
//                        da = new SqlDataAdapter(cmd);


//                    }

//                }
//                catch (Exception)
//                {

//                    throw;
//                }

//            }

//            SqlDataAdapter Da = new SqlDataAdapter();
//            DataTable Dt = new DataTable();
//            try
//            {
//                //Ejecuta la Consulta del Procedimiento Almacenado
//                comando.Connection = Conexion.getConexion();
//                Da = new SqlDataAdapter(comando);
//                Da.Fill(Dt);
//            }

//            catch (Exception ex)
//            //Regresa el resultado de una exepcion
//            { throw ex; }

//            //Cierra la conexion y retorna el datatable
//            finally
//            { comando.Connection.Close(); }

//            //Retorna el Resultado
//            return Dt;
//        }


//        using (var context = new DataBaseContext())
//{
//    var dt = new DataTable();
//    var conn = context.Database.Connection;
//    var connectionState = conn.State;
//    try
//    {
//        if (connectionState != ConnectionState.Open) conn.Open();
//        using (var cmd = conn.CreateCommand())
//        {
//            cmd.CommandText = "GetAvailableItems";
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.Parameters.Add(new SqlParameter("jobCardId", 100525));
//            using (var reader = cmd.ExecuteReader())
//            {
//                dt.Load(reader);
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        // error handling
//        throw;
//    }
//    finally
//    {
//        if (connectionState != ConnectionState.Closed) conn.Close();
//    }
//    return dt;
//}






    }
}
