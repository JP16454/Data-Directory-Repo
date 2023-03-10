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
    public class CatFormaPagoData
    {
        public List<CatFormaPagoEntity> ConsultaFormaPagoAll()
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<CatFormaPagoEntity>("[dbo].[SelCatalogoFormaPago_SP]").ToList();
            }
        }
    }
}
