//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_Final.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BeforeExamGrade
    {
        public int ID { get; set; }
        public Nullable<int> DailyPoint { get; set; }
        public Nullable<System.DateTime> PointDate { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> StudentID { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
