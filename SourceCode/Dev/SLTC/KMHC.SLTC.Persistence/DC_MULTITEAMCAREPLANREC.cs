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
    
    public partial class DC_MULTITEAMCAREPLANREC
    {
        public DC_MULTITEAMCAREPLANREC()
        {
            this.DC_MULTITEAMCAREPLAN = new HashSet<DC_MULTITEAMCAREPLAN>();
        }
    
        public long FEENO { get; set; }
        public string REGNO { get; set; }
        public string NURSEAIDES { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CHECKDATE { get; set; }
        public string CHECKEDBY { get; set; }
        public long SEQNO { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
    
        public virtual ICollection<DC_MULTITEAMCAREPLAN> DC_MULTITEAMCAREPLAN { get; set; }
        public virtual DC_MULTITEAMCAREPLANEVAL DC_MULTITEAMCAREPLANEVAL { get; set; }
    }
}