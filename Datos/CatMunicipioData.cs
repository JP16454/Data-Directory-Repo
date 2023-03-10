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
    public class CatMunicipioData
    {

        public List<CatMunicipioEntity> ConsultaMunicipiosAll(int? idEstado)
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatMunicipioEntity>("[dbo].[Sel_Catalogo_Municipio_SP] {0}", idEstado).ToList();
            }
        }

    }
}
