using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatDireccionBusiness
    {
        public static bool InsertarDireccion(CatDireccionEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatDireccionData.InsertarDireccion(Dato);
            return Respuesta;
        }




    }
}
