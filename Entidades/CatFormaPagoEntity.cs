using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class CatFormaPagoEntity
    {
        [Key]
        public int? IdFormaPago { get; set; }
        public string FormaPago { get; set; }
        public int? InformacionExtra { get; set; }

    }
}
