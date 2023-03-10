using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class MenuEntidades
    {


        [Key]
        public string NombreMenu { get; set; }

        [Key]
        public int IdentificadorMenu { get; set; }

        [Key]
        public int IdentificadorPadre { get; set; }

        [Key]
        public string NombreFormulario { get; set; }

        [Key]
        public int Estatus { get; set; }

    }
}
