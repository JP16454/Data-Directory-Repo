using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using Entidades;
using DatosORM;

namespace Datos
{

    public class UsuarioData
    {

        public List<UsuarioEntidades> ValidarAcceso(UsuarioEntidades usuarios)
        {
            using (Navitur1Entities Context = new Navitur1Entities())
            {
                return Context.Database.SqlQuery<UsuarioEntidades>("[dbo].[SEL_VALIDA_USUARIO_SP] {0}, {1}",
                    usuarios.Usuario,
                    usuarios.Password
                    ).ToList();
            }
        }


        /*
        public static bool Insertar_Urs(UsuarioEntidades Dato)
        {
            bool Respuesta = false;
            using (MenuWPFEntities Contexto = new MenuWPFEntities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[SP_INSERTAR_USUARIO] {0},{1},{2},{3},{4}",
                    //Dato.IdUsuario,
                    Dato.NivelUsuario,
                    Dato.Usuario1,
                    Dato.Password,
                    Dato.Nombre
                    //Dato.Estatus
                    );

        Respuesta = true;

            }
            return Respuesta;
        }

        public static bool Modificar_Urs(UsuarioEntidades Dato)
        {
            bool Respuesta = false;
            using (MenuWPFEntities Contexto = new MenuWPFEntities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[SP_MODIFICAR_USUARIO] {0},{1},{2},{3},{4}",
                    Dato.IdUsuario,
                    Dato.NivelUsuario,
                    Dato.Usuario1,
                    Dato.Password,
                    Dato.Nombre
                    //Dato.Estatus
                    );

                Respuesta = true;

            }
            return Respuesta;
        }

        public static bool Eliminar_Urs(UsuarioEntidades Dato)
        {
            bool Respuesta = false;
            using (MenuWPFEntities Contexto = new MenuWPFEntities())
            {
                Contexto.Database.ExecuteSqlCommand("[dbo].[SP_ELIMINAR_USUARIO] {0}",
                    Dato.IdUsuario);

                Respuesta = true;

            }
            return Respuesta;
        }


        public string ConsultaNominaUrs(UsuarioEntidades Dato)
        {
            using (MenuWPFEntities Contexto = new MenuWPFEntities())
            {
                return Contexto.Database.SqlQuery<string>("[dbo].[SP_CONSULTAUSR] {0}", Dato.IdUsuario).First();
            }
        }
          */


        public List<UsuarioEntidades> ConsultaUsuariosAll()
        {
            using (Navitur1Entities Contexto = new Navitur1Entities())
            {
                return Contexto.Database.SqlQuery<UsuarioEntidades>("[dbo].[SEL_USUARIOS_ALL_SP]").ToList();
            }
        }
      








    }


}
