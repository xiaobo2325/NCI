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
    
    public partial class NCI_MEDICALMATERIALBAK
    {
        public string MATERIALCODE { get; set; }
        public string MCRULEID { get; set; }
        public string MATERIALTYPE { get; set; }
        public string MATERIALNAME { get; set; }
        public string MATERIALLEVEL { get; set; }
        public bool ISCHINAPRODUCT { get; set; }
        public string ORGIN { get; set; }
        public string MANUFACTURER { get; set; }
        public string SPEC { get; set; }
        public string UNITS { get; set; }
        public string USAGE { get; set; }
        public string ATTENTION { get; set; }
        public Nullable<decimal> GUIDEPRICE { get; set; }
        public Nullable<decimal> MAXPRICE { get; set; }
        public Nullable<int> NCIMONTHLYMAXUSAGE { get; set; }
        public string COMMENT { get; set; }
        public Nullable<System.DateTime> LASTUPDATETIME { get; set; }
        public string PINYIN { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<System.DateTime> BAKTIME { get; set; }
        public string BAKBY { get; set; }
    }
}