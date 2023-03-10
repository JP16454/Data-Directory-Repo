using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Configuration;
using System.Data;
 
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class CatDireccionEntity
    {
        [Key]
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public Nullable<int> NumInterior { get; set; }
        public Nullable<int> NumExterior { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public Nullable<int> IdMunicipio { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> IdPais { get; set; }
        public Nullable<int> Estatus { get; set; }



    }
}
