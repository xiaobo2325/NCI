//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class LTC_NCIEVALUATEDTL
    {
        public int ID { get; set; }
        public Nullable<int> NCIEVALUATEID { get; set; }
        public string ITEMCODE { get; set; }
        public Nullable<int> SUBITEMID { get; set; }
        public Nullable<int> SCORE { get; set; }
    
        public virtual LTC_NCIEVALUATE LTC_NCIEVALUATE { get; set; }
    }
}