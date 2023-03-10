using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class MenuxUsrEntidades
    {


        [Key]
        public int IdUsuario { get; set; }

        [Key]
        public int NivelUsuario { get; set; }

        [Key]
        public int IdentificadorMenu { get; set; }

        [Key]
        public int Estatus { get; set; }


    }
}
