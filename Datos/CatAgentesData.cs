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
    public class CatAgentesData
    {
        
        //public List<CatAgentesEntity> ConsultaAgentesAll()
        //{
        //    using (Navitur1Entities Contexto = new Navitur1Entities())
        //    {
        //        return Contexto.Database.SqlQuery<CatAgentesEntity>("[dbo].[SelCatalogoAgentesSP]").ToList();
        //    }
        //}

        public List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatAgentesDetalleEntity>("[dbo].[SelCatalogoAgentesSP] {0},{1}",
                    objeto.IdAgente, objeto.Nombre).ToList();
            }
        }

        public List<CatAgentesEntity> ConsultaAgentesId(int? id, string nombre)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatAgentesEntity>("[dbo].[SelCatalogoAgentesSP] {0},{1}", id, nombre).ToList();
            }
        }


        public CatAgentesEntity RecuperarAgenteId(int? id)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatAgentesEntity>("[dbo].[Sel_Catalogo_Agentes_Id_SP] {0}", id).First();
            }
        }



        public static bool InsertarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[Ins_Catalogo_Agentes_SP] {0},{1},{2},{3},{4}",
                    Dato.Nombre,
                    Dato.ApellidoPaterno,
                    Dato.ApellidoMaterno,
                    Dato.Telefono,
                    Dato.Celular
                    //Dato.Estatus
                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EditarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[Upd_Catalogo_Agentes_SP] {0},{1},{2},{3},{4}",
                    Dato.IdAgente,
                    Dato.Nombre,
                    Dato.ApellidoPaterno,
                    Dato.ApellidoMaterno,
                    Dato.IdDireccion
                    //Dato.Estatus
                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EliminarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[Del_Catalogo_Agentes_SP] {0}", Dato.IdAgente);
                Respuesta = true;
            }

            return Respuesta;
        }

    }
}
