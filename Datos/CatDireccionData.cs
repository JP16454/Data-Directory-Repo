using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using DatosORM;
using System.Data.EntityClient;


namespace Datos
{
    public class CatDireccionData
    {

        public static bool InsertarDireccion(CatDireccionEntity Dato)
        {
            bool Respuesta = false;

            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[Ins_Catalogo_Direccion_SP] {0},{1},{2},{3},{4},{5},{6},{7}",
                    Dato.Calle,
                    Dato.NumInterior,
                    Dato.NumExterior,
                    Dato.Colonia,
                    Dato.CodigoPostal,
                    Dato.IdMunicipio,
                    Dato.IdEstado,
                    Dato.IdPais
                    );

                Respuesta = true;
            }

            return Respuesta;
        }

    }
}
