//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Usuario
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Usuario()
        //{
        //    this.MenuxUsr = new HashSet<MenuxUsr>();
        //}
    
        [Key]
        public int IdUsuario { get; set; }
        public int NivelUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public int AutorizaComision { get; set; }
        public int AutorizaTransmitido { get; set; }
        public int Estatus { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<MenuxUsr> MenuxUsr { get; set; }
        //public virtual Privilegio Privilegio { get; set; }
    }
}