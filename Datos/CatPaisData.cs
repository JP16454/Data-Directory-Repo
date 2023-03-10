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
    public class CatPaisData
    {

        public List<CatPaisEntity> ConsultaPaisAll()
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatPaisEntity>("[dbo].[Sel_Catalogo_Pais_SP]").ToList();
            }
        }


    }
}
