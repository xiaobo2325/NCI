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
    
    public partial class LTC_PRECHARGE
    {
        public int PRECHARGEID { get; set; }
        public string BALANCEID { get; set; }
        public decimal AMOUNT { get; set; }
        public string PAYMENTTYPE { get; set; }
        public string PAYER { get; set; }
        public string RECEIPTNO { get; set; }
        public string COMMENT { get; set; }
        public string OPERATOR { get; set; }
        public Nullable<System.DateTime> PRECHARGETIME { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual LTC_RESIDENTBALANCE LTC_RESIDENTBALANCE { get; set; }
    }
}