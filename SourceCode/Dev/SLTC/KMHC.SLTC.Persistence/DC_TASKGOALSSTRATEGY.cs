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
    
    public partial class DC_TASKGOALSSTRATEGY
    {
        public long EVALPLANID { get; set; }
        public string QUESTIONTYPE { get; set; }
        public string CPDIA { get; set; }
        public string QUESTIONDESC { get; set; }
        public string TREATMENTGOAL { get; set; }
        public string QUESTIONANALYSIS { get; set; }
        public string PLANACTIVITY { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string RECORDBY { get; set; }
        public string CHECKDATE { get; set; }
        public string CHECKEDBY { get; set; }
        public string EVALUATIONVALUE { get; set; }
        public string UNFINISHREASON { get; set; }
        public long ID { get; set; }
        public Nullable<int> MAJORTYPE { get; set; }
    
        public virtual DC_SWREGEVALPLAN DC_SWREGEVALPLAN { get; set; }
    }
}