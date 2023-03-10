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
    public class CatProveedoresData
    {

        //public List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        //{
        //    using (Navitur1Entities Contexto = new Navitur1Entities())
        //    {
        //        return Contexto.Database.SqlQuery<CatAgentesDetalleEntity>("[dbo].[SelCatalogoAgentesSP] {0},{1}",
        //            objeto.IdAgente, objeto.Nombre).ToList();
        //    }
        //}

            

        public List<CatProveedoresEntity> ConsultaProveedoresId(int? id, string proveedor)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatProveedoresEntity>("[dbo].[SelCatalogoProveedoresSP] {0},{1}", id, proveedor).ToList();
            }
        }


        public CatProveedoresEntity RecuperarProveedoresId(int? id)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatProveedoresEntity>("[dbo].[SelCatalogoProveedoresIdSP] {0}", id).First();
            }
        }



        public static bool InsertarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[InsCatalogoProveedoresSP] {0},{1},{2},{3},{4},{5},{6},{7}",
                    Dato.Proveedor,
                    Dato.RazonSocial,
                    Dato.RFC,
                    //Dato.IdDireccion,
                    Dato.Telefono,
                    Dato.Email,
                    Dato.Comision,
                    Dato.IdFormaPago,
                    Dato.Observaciones
                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EditarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[UpdCatalogoProveedoresSP] {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    Dato.IdProveedor,
                    Dato.Proveedor,
                    Dato.RazonSocial,
                    Dato.RFC,
                    Dato.IdDireccion,
                    Dato.Telefono,
                    Dato.Email,
                    Dato.Comision,
                    Dato.IdFormaPago,
                    Dato.Observaciones

                    );

                Respuesta = true;
            }

            return Respuesta;
        }

        public static bool EliminarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[DelCatalogoProveedoresSP] {0}", Dato.IdProveedor);
                Respuesta = true;
            }

            return Respuesta;
        }




    }
}
