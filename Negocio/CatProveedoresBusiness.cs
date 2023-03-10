using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatProveedoresBusiness
    {

        //public static List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        //{
        //    CatAgentesData agentesdatos = new CatAgentesData();
        //    return agentesdatos.ConsultaAgentesAll(objeto);
        //}
         
        public static List<CatProveedoresEntity> ConsultaProveedoresId(int? id, string proveedor)
        {
            CatProveedoresData proveedordatos = new CatProveedoresData();
            return proveedordatos.ConsultaProveedoresId(id, proveedor);
        }


        public CatProveedoresEntity RecuperarProveedoresId(int? id)
        {
            CatProveedoresData agenciadatos = new CatProveedoresData();
            return agenciadatos.RecuperarProveedoresId(id);
        }


        public static bool InsertarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatProveedoresData.InsertarProveedores(Dato);
            return Respuesta;
        }

        public static bool EditarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatProveedoresData.EditarProveedores(Dato);
            return Respuesta;
        }


        public static bool EliminarProveedores(CatProveedoresEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatProveedoresData.EliminarProveedores(Dato);
            return Respuesta;
        }



    }
}
