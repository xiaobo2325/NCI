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
    
    public partial class LTC_REGNCIINFO
    {
        public int ID { get; set; }
        public long FEENO { get; set; }
        public string CERTNO { get; set; }
        public System.DateTime CERTSTARTTIME { get; set; }
        public System.DateTime CERTEXPIREDTIME { get; set; }
        public Nullable<System.DateTime> APPLYHOSTIME { get; set; }
        public string CARETYPEID { get; set; }
        public decimal NCIPAYLEVEL { get; set; }
        public decimal NCIPAYSCALE { get; set; }
        public int STATUS { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
    }
}