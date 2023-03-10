using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using DatosORM;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Datos
{
    public class CatAgenciasData
    {
        

        //public List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        //{
        //    using (Navitur1Entities Contexto = new Navitur1Entities())
        //    {
        //        return Contexto.Database.SqlQuery<CatAgentesDetalleEntity>("[dbo].[SelCatalogoAgentesSP] {0},{1}",
        //            objeto.IdAgente, objeto.Nombre).ToList();
        //    }
        //}

        public List<CatAgenciasEntity> ConsultaAgenciasId(int? id, string agencia)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatAgenciasEntity>("[dbo].[SelCatalogoAgenciasSP] {0},{1}", id, agencia).ToList();
            }
        }


        public CatAgenciasEntity RecuperarAgenciasId(int? id)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatAgenciasEntity>("[dbo].[SelCatalogoAgenciasIdSP] {0}", id).First();
            }
        }



        public static bool InsertarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[InsCatalogoAgenciasSP] {0},{1},{2},{3},{4},{5},{6}",
                    Dato.Agencia,
                    Dato.RazonSocial,
                    Dato.RFC,
                    Dato.Telefono,
                    Dato.Email,
                    Dato.Comision,
                    Dato.Observaciones
                    //Dato.Estatus
                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EditarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[UpdCatalogoAgenciasSP] {0},{1},{2},{3},{4},{5},{6},{7}",
                    Dato.IdAgencia,
                    Dato.Agencia,
                    Dato.RazonSocial,
                    Dato.RFC,
                    Dato.Telefono,
                    Dato.Email,
                    Dato.Comision,
                    Dato.Observaciones

                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EliminarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[DelCatalogoAgenciasSP] {0}", Dato.IdAgencia);
                Respuesta = true;
            }

            return Respuesta;
        }



    }
}
