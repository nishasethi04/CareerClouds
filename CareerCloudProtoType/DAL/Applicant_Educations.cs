//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applicant_Educations
    {
        public System.Guid Id { get; set; }
        public System.Guid Applicant { get; set; }
        public string Major { get; set; }
        public string Certificate_Diploma { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> Completion_Date { get; set; }
        public Nullable<byte> Completion_Percent { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        public virtual Applicant_Profiles Applicant_Profiles { get; set; }
    }
}
