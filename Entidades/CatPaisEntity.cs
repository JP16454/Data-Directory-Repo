using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class CatPaisEntity
    {

        [Key]
        public int? IdPais { get; set; }
        public string NombrePais { get; set; }

    }
}
