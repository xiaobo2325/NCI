﻿using KMHC.SLTC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMHC.SLTC.Business.Entity.Model
{
    public class Nursing
    {

    }


    public class CareDemandEval
    {
        public long ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string NEXTEVALUATEBY { get; set; }
        public Nullable<int> COUNT { get; set; }
        public string EVALUATEBY { get; set; }
        public Nullable<bool> HEALTHFLAG { get; set; }
        public string HEALTHDESC { get; set; }
        public Nullable<bool> INFECTIONFLAG { get; set; }
        public string INFECTIONDESC { get; set; }
        public Nullable<bool> VITALSIGNFLAG { get; set; }
        public Nullable<decimal> BODYTEMP { get; set; }
        public Nullable<int> PULSE { get; set; }
        public Nullable<int> BREATHE { get; set; }
        public Nullable<int> SBP { get; set; }
        public Nullable<int> DBP { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public string CONSCIOUSNESS { get; set; }
        public string CONSCIOUSNESS_E { get; set; }
        public string CONSCIOUSNESS_V { get; set; }
        public string CONSCIOUSNESS_M { get; set; }
        public Nullable<bool> APPEARANCEFLAG { get; set; }
        public string APPEARANCEDESC { get; set; }
        public string ATTITUDE { get; set; }
        public Nullable<bool> BREATHPROBLEMFLAG { get; set; }
        public string BREATEDESC { get; set; }
        public string SECRETIONDESC { get; set; }
        public string SECRETIONNATURE { get; set; }
        public string SECRETIONAMT { get; set; }
        public string COUGHDESC { get; set; }
        public string BREATHAIDTOOLS { get; set; }
        public string SMOKINGHISTORY { get; set; }
        public Nullable<bool> NUTRITIONFLAG { get; set; }
        public string EATTYPE { get; set; }
        public string DIETTYPEDESC { get; set; }
        public string FOODINTAKEAMT { get; set; }
        public string WATERAMT { get; set; }
        public string WATERENOUGHAMT { get; set; }
        public string ORALMUCOSA { get; set; }
        public string DENTUREFIXED { get; set; }
        public string DENTUREMOVABLE { get; set; }
        public string DENTURESAFETY { get; set; }
        public string DENTUREFIT { get; set; }
        public string DENTUREHEALTH { get; set; }
        public Nullable<bool> EXCRETIONFLAG { get; set; }
        public string MICTURITIONDESC { get; set; }
        public string MICTURITIONAIDTYPE { get; set; }
        public string DEFECATIONDESC { get; set; }
        public string DEFECATIONFREQ { get; set; }
        public string DEFECATIONAIDDESC { get; set; }
        public string OTHERDEFECATION { get; set; }
        public Nullable<bool> SLEEPFLAG { get; set; }
        public Nullable<decimal> SLEEPHOURS_N { get; set; }
        public Nullable<decimal> SLEEPHOURS_D { get; set; }
        public string SLEEPDESC { get; set; }
        public string SLEEPPILLS { get; set; }
        public Nullable<bool> ACTIVEFUNFLAG { get; set; }
        public string GAIT { get; set; }
        public string PHYSICALIMPAIRMENT { get; set; }
        public string MUSCLE_LH { get; set; }
        public string MUSCLE_RH { get; set; }
        public string MUSCLE_LF { get; set; }
        public string MUSCLE_RF { get; set; }
        public string AIDTOOLS { get; set; }
        public Nullable<bool> SKINFLAG { get; set; }
        public string SKINDESC { get; set; }
        public string SKINPARTDESC { get; set; }
        public string WOUNDDESC { get; set; }
        public string BEDSOREPART { get; set; }
        public string BEDSORESIZE { get; set; }
        public string BEDSOREDEGREE { get; set; }
        public Nullable<bool> FEELINGFLAG { get; set; }
        public string SIGHTDESC { get; set; }
        public string SIGHT_L { get; set; }
        public string SIGHT_R { get; set; }
        public string LISTENDESC { get; set; }
        public string LISTEN_L { get; set; }
        public string LISTEN_R { get; set; }
        public string SENSATIONDESC { get; set; }
        public string PAINDESC { get; set; }
        public string PAINPART { get; set; }
        public string PAIN_FREQ { get; set; }
        public string PAIN_NUTURE { get; set; }
        public string PAIN_SHOW { get; set; }
        public string PAINDRUGDESC { get; set; }
        public string ILLUSIONDESC { get; set; }
        public Nullable<int> ADLSCORE { get; set; }
        public Nullable<int> MMSESCORE { get; set; }
        public string MMSEDESC { get; set; }
        public Nullable<bool> INTERACTIONFLAG { get; set; }
        public string COMMUNICATESKILL { get; set; }
        public string COMMUNICATETYPE { get; set; }
        public string COMMUNICATEDESC { get; set; }
        public string APPELLATION { get; set; }
        public string EMOTION { get; set; }
        public string ATTITUDEREMARK { get; set; }
        public Nullable<bool> ALLERGYFLAG { get; set; }
        public string ALLERGY_DRUG { get; set; }
        public string ALLERGY_FOOD { get; set; }
        public string ALLERGY_OTHERS { get; set; }
        public string GOAL_S { get; set; }
        public string GOAL_L { get; set; }
        public string DESCRIPTION { get; set; }
        public string PIC1 { get; set; }
        public string PIC2 { get; set; }
        public string ADLRESULTS { get; set; }
        public string iADLRESULTS { get; set; }
        public string KS_RESULTS { get; set; }
        public string YY_RESULTS { get; set; }
        public string FALLRESULTS { get; set; }
        public string PRESSURESORE { get; set; }
        public string MUSCLETYPE_LH { get; set; }
        public string MUSCLETYPE_RH { get; set; }
        public string MUSCLETYPE_LF { get; set; }
        public string MUSCLETYPE_RF { get; set; }
        public string JOINTTYPE_LH { get; set; }
        public string JOINTTYPE_RH { get; set; }
        public string JOINTTYPE_LF { get; set; }
        public string JOINTTYPE_RF { get; set; }
        public string GCSRESULTS { get; set; }
        public string PAINDEGREEDESC_W { get; set; }
        public string ACCIDENT_W { get; set; }
        public string ABNORMAL_W { get; set; }
        public string HEARINGAID { get; set; }
        public string SIGHTCORRECTED { get; set; }
        public string BALANCE_SIT { get; set; }
        public string BALANCE_STAND { get; set; }
        public string BALANCE_WALK { get; set; }
        public string URINESHAPE { get; set; }
        public string GUT_SOUND { get; set; }
        public string GUT_FLATULENCE { get; set; }
        public string GUT_LUMP { get; set; }
        public string STOOLSHAPE { get; set; }
        public string MOUTHPAIN { get; set; }
        public string TOOTHDESC { get; set; }
        public string SWALLOWDESC { get; set; }
        public string LIGHTREFLECTION { get; set; }
        public string HEARTBEAT { get; set; }
        public string LIMBEDEMA_LH { get; set; }
        public string LIMBEDEMA_RH { get; set; }
        public string LIMBEDEMA_LF { get; set; }
        public string LIMBEDEMA_RF { get; set; }
        public string CARENEEDS { get; set; }
        public string CAREQUESTION { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string ORGID { get; set; }
    }

    public class Evaluation
    {
        public string NAME { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<long> ID { get; set; }
        public Nullable<int> REGNO { get; set; }
        public string SEX { get; set; }
        public Nullable<long> RECORDID { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public string ENVRESULTS { get; set; }
        public string DESCRIPTION { get; set; }
        public string EVALUATEBY { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string NEXTEVALUATEBY { get; set; }
        public string NOTEVALREASON { get; set; }
        public string ORGID { get; set; }
        public string CAUSEREASON { get; set; }
        public string LASTCOMPARE { get; set; }
        public int QUANTITY { get; set; }
    }

    public class EvaluationResult
    {
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public string ENVRESULTS { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public List<QuestionResult> QueResult { get; set; }
        public string CODE { get; set; }
    }


    public class QUESTION
    {
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public int QUESTIONID { get; set; }
        public string QUESTIONNAME { get; set; }
        public string CODE { get; set; }
        public Nullable<int> SHOWNUMBER { get; set; }
        public Nullable<bool> ISSHOW { get; set; }
        public string QUESTIONDESC { get; set; }
        public Nullable<int> CATEGORYID { get; set; }
        public Nullable<bool> SCOREFLAG { get; set; }
        public string ORGID { get; set; }
        public List<QuestionResult> QuestionResult { get; set; }
        public List<MakerItemCollection> MakerItemList { get; set; }
    }

    public class Calculation
    {
        public decimal Score { get; set; }
        public string Result { get; set; }
        public int? RightAnswerCount { get; set; }
        public int CalculationType { get; set; }
    }

    public class RegQuestionList
    {
        public List<REGQUESTION> Data { get; set; } 
    }

    public class REGQUESTION
    {
        public long RECORDID { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> REGNO { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public string ENVRESULTS { get; set; }
        public string DESCRIPTION { get; set; }
        public string EVALUATEBY { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string NEXTEVALUATEBY { get; set; }
        public string NOTEVALREASON { get; set; }
        public string ORGID { get; set; }
        public string CAUSEREASON { get; set; }
        public string LASTCOMPARE { get; set; }
        public List<REGQUESTIONDATA> QuestionDataList { get; set; }
    }

    public class REGQUESTIONDATA
    {
        public long ID { get; set; }
        public Nullable<long> RECORDID { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<int> MAKERID { get; set; }
        public Nullable<decimal> MAKERVALUE { get; set; }
        public Nullable<int> LIMITEDVALUEID { get; set; }
    }

    public class MakerItemCollection
    {
        public int MAKERID { get; set; }
        public string MAKENAME { get; set; }
        public Nullable<int> SHOWNUMBER { get; set; }
        public bool? ISSHOW { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public string DATATYPE { get; set; }
        public Nullable<int> LIMITEDID { get; set; }
        public string CATEGORY { get; set; }
        public List<MakerItemValue> Answers { get; set; }
        public decimal? SELECTVALUE { get; set; }
        public Nullable<int> LIMITEDVALUEID { get; set; }
    }

    public class QuestionResult
    {
        public int RESULTID { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<decimal> LOWBOUND { get; set; }
        public Nullable<decimal> UPBOUND { get; set; }
        public string RESULTNAME { get; set; }
    }

    public class MakerItemValue
    {
        public bool? ISDEFAULT { get; set; }
        public int LIMITEDID { get; set; }
        public decimal? LIMITEDVALUE { get; set; }
        public int LIMITEDVALUEID { get; set; }
        public string LIMITEDVALUENAME { get; set; }
        public int? SHOWNUMBER { get; set; }

    }





    public class PIPELINEEVALINFO
    {
        public decimal ID { get; set; }
        public Nullable<decimal> FEENO { get; set; }
        public Nullable<decimal> REGNO { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> RECENTDATE { get; set; }
        public Nullable<int> INTERVAL { get; set; }
        public Nullable<System.DateTime> NEXTDATE { get; set; }
        public string STATE { get; set; }
        public string OPERATOR { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string ORGID { get; set; }
        public Nullable<decimal> SEQ { get; set; }
        public string KIND { get; set; }
        public string FEATHER { get; set; }
        public string AGUGE { get; set; }
        public string PIPELINENAME { get; set; }


    }


    public class InjectionView
    {
        public int REGNO { get; set; }
        public string NAME { get; set; }
        public int QUANTITY { get; set; }
        public Nullable<long> ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public string ITEMTYPE { get; set; }
        public string STATE { get; set; }
        public string TRACESTATE { get; set; }
        public Nullable<System.DateTime> INJECTDATE { get; set; }
        public Nullable<int> INTERVAL { get; set; }
        public Nullable<System.DateTime> NEXTINJECTDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string OPERATOR { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string CREATEBY { get; set; }
        public string NEXTOPERATEBY { get; set; }
        public string ORGID { get; set; }

    }


    #region DC
    public partial class EVALQUESTIONRESULT
    {
        public long ID { get; set; }
        public Nullable<long> RECORDID { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public Nullable<int> MAKERID { get; set; }
        public Nullable<decimal> MAKERVALUE { get; set; }
        public Nullable<int> LIMITEDVALUEID { get; set; }

    }

    public partial class EVALQUESTION
    {

        public long RECORDID { get; set; }
        public Nullable<long> ID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public string REGNO { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public string QUESTIONCODE { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public Nullable<System.DateTime> EVALDATE { get; set; }
        public Nullable<System.DateTime> NEXTEVALDATE { get; set; }
        public string EVALRESULT { get; set; }
        public string DESCRIPTION { get; set; }
        public string ORGID { get; set; }
        public List<EVALQUESTIONRESULT> QuestionDataList { get; set; }
    }

    public partial class EVALQUESTION2
    {
        public long RECORDID { get; set; }
        public Nullable<long> FEENO { get; set; }
        public Nullable<int> QUESTIONID { get; set; }
        public string REGNO { get; set; }
        public Nullable<int> EVALNUMBER { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public string EVALRESULT { get; set; }
        public string CODE { get; set; }
        public string ORGID { get; set; }
    }
    #endregion

}