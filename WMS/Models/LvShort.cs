//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LvShort
    {
        public int SlID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<System.DateTime> DutyDate { get; set; }
        public string EmpDate { get; set; }
        public Nullable<System.TimeSpan> SHour { get; set; }
        public Nullable<System.TimeSpan> EHour { get; set; }
        public Nullable<System.TimeSpan> THour { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Emp Emp { get; set; }
    }
}
