//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCRUD.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_MUNICIPIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MUNICIPIO()
        {
            this.TB_EMPRESA = new HashSet<TB_EMPRESA>();
            this.TB_USUARIO = new HashSet<TB_USUARIO>();
        }
    
        public int mnp_codigo_ibge { get; set; }
        public string mnp_nome { get; set; }
        public System.DateTime mnp_dt_cadastro { get; set; }
        public bool mnp_deletado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_EMPRESA> TB_EMPRESA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }
    }
}