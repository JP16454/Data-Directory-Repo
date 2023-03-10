using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatAgenciasBusiness
    {

        //public static List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        //{
        //    CatAgentesData agentesdatos = new CatAgentesData();
        //    return agentesdatos.ConsultaAgentesAll(objeto);
        //}

        public static List<CatAgenciasEntity> ConsultaAgenciaId(int? id, string agencia)
        {
            CatAgenciasData agenciadatos = new CatAgenciasData();
            return agenciadatos.ConsultaAgenciasId(id, agencia);
        }


        public CatAgenciasEntity RecuperarAgenciaId(int? id)
        {
            CatAgenciasData agenciadatos = new CatAgenciasData();
            return agenciadatos.RecuperarAgenciasId(id);
        }


        public static bool InsertarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgenciasData.InsertarAgencias(Dato);
            return Respuesta;
        }

        public static bool EditarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgenciasData.EditarAgencias(Dato);
            return Respuesta;
        }


        public static bool EliminarAgencias(CatAgenciasEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgenciasData.EliminarAgencias(Dato);
            return Respuesta;
        }



    }
}
