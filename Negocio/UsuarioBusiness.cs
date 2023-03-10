using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entidades;
using Datos;
using DatosORM;


namespace Negocio
{
    public class UsuarioBusiness
    {


        public List<UsuarioEntidades> ValidarAcceso(UsuarioEntidades usuarios)
        {
            UsuarioData Context = new UsuarioData();
            return Context.ValidarAcceso(usuarios);

        }

        public List<UsuarioEntidades> ConsultaUsuariosAll()
        {
            UsuarioData Context = new UsuarioData();
            return Context.ConsultaUsuariosAll();

        }

    }
}
