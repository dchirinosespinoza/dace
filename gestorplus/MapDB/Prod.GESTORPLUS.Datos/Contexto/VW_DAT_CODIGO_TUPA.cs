//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prod.BUPER.Datos.Contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_DAT_CODIGO_TUPA
    {
        public int id_codigo { get; set; }
        public string codigo_tributo { get; set; }
        public string nom_codigo { get; set; }
        public int id_tupa { get; set; }
        public Nullable<int> numero_tupa { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> codigo_dependencia { get; set; }
        public string siglas { get; set; }
        public string dependencia { get; set; }
        public string estado { get; set; }
    }
}
