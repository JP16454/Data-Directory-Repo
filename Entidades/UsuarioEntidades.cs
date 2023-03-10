using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class UsuarioEntidades
    {
        [Key]
        public Int64 IdUsuario { get; set; }
        [Key]
        public Int64 NivelUsuario { get; set; }
        [Key]
        public string Usuario { get; set; }
        [Key]
        public string Password { get; set; }
        [Key]
        public string Nombre { get; set; }
        [Key]
        public int Estatus { get; set; }
        [Key]
        public int RowExiste { get; set; }
    }
}
