using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatPaisBusiness
    {
        public static List<CatPaisEntity> ConsultaPaisAll()
        {
            CatPaisData paisdatos = new CatPaisData();
            return paisdatos.ConsultaPaisAll();
        }


    }
}
