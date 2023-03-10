using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatFormaPagoBusiness
    {
        public static List<CatFormaPagoEntity> ConsultaFormaPagoAll()
        {
            CatFormaPagoData formapagodatos = new CatFormaPagoData();
            return formapagodatos.ConsultaFormaPagoAll();
        }

    }
}
