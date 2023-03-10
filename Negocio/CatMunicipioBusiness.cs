using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatMunicipioBusiness
    {

        public static List<CatMunicipioEntity> ConsultaMunicipiosAll(int? idEstado)
        {
            CatMunicipioData municipiodatos = new CatMunicipioData();
            return municipiodatos.ConsultaMunicipiosAll(idEstado);
        }




    }
}
