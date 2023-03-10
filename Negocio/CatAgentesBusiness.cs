using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class CatAgentesBusiness
    {
        //public static List<CatAgentesEntity> ConsultaAgentesAll()
        //{
        //    CatAgentesData agentesdatos = new CatAgentesData();
        //    return agentesdatos.ConsultaAgentesAll();
        //}
        public static List<CatAgentesDetalleEntity> ConsultaAgentesAll(CatAgentesEntity objeto)
        {
            CatAgentesData agentesdatos = new CatAgentesData();
            return agentesdatos.ConsultaAgentesAll(objeto);
        }

        public static List<CatAgentesEntity> ConsultaAgentesId(int? id, string nombre)
        {
            CatAgentesData agentesdatos = new CatAgentesData();
            return agentesdatos.ConsultaAgentesId(id, nombre);
        }


        public CatAgentesEntity RecuperarAgenteId(int? id)
        {
            CatAgentesData agentesdatos = new CatAgentesData();
            return agentesdatos.RecuperarAgenteId(id);
        }


        public static bool InsertarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgentesData.InsertarAgentes(Dato);
            return Respuesta;
        }

        public static bool EditarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgentesData.EditarAgentes(Dato);
            return Respuesta;
        }


        public static bool EliminarAgentes(CatAgentesEntity Dato)
        {
            bool Respuesta = false;
            Respuesta = CatAgentesData.EliminarAgentes(Dato);
            return Respuesta;
        }


    }
}
