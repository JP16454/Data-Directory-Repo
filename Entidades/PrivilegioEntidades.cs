using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class PrivilegioEntidades
    {
        [Key]
        public int Nivel { get; set; }
        [Key]
        public string Descripcion { get; set; }
        [Key]
        public int Estatus { get; set; }


    }
}
