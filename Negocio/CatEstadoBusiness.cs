using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatEstadoBusiness
    {

        public static List<CatEstadoEntity> ConsultaEstadoAll()
        {
            CatEstadoData estadodatos = new CatEstadoData();
            return estadodatos.ConsultaEstadoAll();
        }
    }
}
