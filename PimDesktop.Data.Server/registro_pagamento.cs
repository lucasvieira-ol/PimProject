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
    
    public partial class registro_pagamento
    {
        public int id_pagamento { get; set; }
        public int id_reserva { get; set; }
        public string descricao { get; set; }
        public Nullable<decimal> valor { get; set; }
        public string tipo_pagamento { get; set; }
        public Nullable<int> parcelas { get; set; }
        public bool estorno { get; set; }
        public bool registro_pago { get; set; }
        public System.DateTime data_cadastro { get; set; }
        public Nullable<System.DateTime> data_pagamento { get; set; }
    
        public virtual reserva reserva { get; set; }
    }
}
