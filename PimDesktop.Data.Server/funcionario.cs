//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PimDesktop.Data.Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public funcionario()
        {
            this.reserva = new HashSet<reserva>();
        }
    
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string funcao { get; set; }
        public System.DateTime data_cadastro { get; set; }
        public System.DateTime data_admissao { get; set; }
        public Nullable<System.DateTime> data_demissao { get; set; }
        public bool ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
    }
}
