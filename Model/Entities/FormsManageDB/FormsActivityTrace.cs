﻿using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class FormsActivityTrace
    {
        public long ActivityTraceId { get; set; }
        public string? ActivityGuid { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityStartDate { get; set; }
        public string? ActivityEndDate { get; set; }
        public bool IsLimited { get; set; }
        public bool CanSubmitOnce { get; set; }
        public bool IsAnonymous { get; set; }
        public string? CreationDate { get; set; }
        public string? UpdateDate { get; set; }
        public string? FromEffectDate { get; set; }
        public string? ToEffectDate { get; set; }
        public int RecordStatusCode { get; set; }
        public string? UpdateUserId { get; set; }
        public string? EvaluatedAndEvaluators { get; set; }
        public string? Forms { get; set; }
        public int? FormsDBID { get; set; }
        public string? FormsDBName { get; set; }

        public virtual FormsRecordStatus RecordStatusCodeNavigation { get; set; } = null!;
    }
}
