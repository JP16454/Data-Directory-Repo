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
    public class CatEstadoData
    {

        public List<CatEstadoEntity> ConsultaEstadoAll()
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatEstadoEntity>("[dbo].[Sel_Catalogo_Estado_SP]").ToList();
            }
        }


    }
}
