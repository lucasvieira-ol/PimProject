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
    
    public partial class usuario_cartao
    {
        public int idCartao { get; set; }
        public int id_usuarioHospede { get; set; }
        public string nome_cartao { get; set; }
        public string numero_cartao { get; set; }
        public Nullable<System.DateTime> data_validade { get; set; }
    
        public virtual usuario_hospede usuario_hospede { get; set; }
    }
}
