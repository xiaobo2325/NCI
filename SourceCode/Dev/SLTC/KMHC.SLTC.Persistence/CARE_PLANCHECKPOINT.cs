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
    
    public partial class CARE_PLANCHECKPOINT
    {
        public int CC_NO { get; set; }
        public Nullable<int> CP_NO { get; set; }
        public string DIAPR { get; set; }
        public string TABLE_NAME { get; set; }
        public string FIELD_NAME { get; set; }
        public string FIELD_VALUE { get; set; }
        public Nullable<int> COMPARE_TYPE { get; set; }
        public Nullable<int> VALUE_WEIGHT { get; set; }
    
        public virtual CARE_PLANPROBLEM CARE_PLANPROBLEM { get; set; }
    }
}