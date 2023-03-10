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
    public class CatProveedoresEntity
    {
       
        public string IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public int? IdDireccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Comision { get; set; }
        public int? IdFormaPago { get; set; }
        public string Observaciones { get; set; }

         
    }
}
