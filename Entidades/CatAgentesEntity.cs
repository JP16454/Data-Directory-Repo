using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Configuration;
using System.Data;

namespace Entidades
{
    public class CatAgentesEntity
    {
  
        public string IdAgente { get; set; }
        
        public string Nombre { get; set; }
        
        public string ApellidoPaterno { get; set; }
        
        public string ApellidoMaterno { get; set; }

        public int? IdDireccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }

    }
}
