//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Career
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applicant_Resumes
    {
        public System.Guid Id { get; set; }
        public System.Guid Applicant { get; set; }
        public string Resume { get; set; }
        public Nullable<System.DateTime> Last_Updated { get; set; }
    
        public virtual Applicant_Profiles Applicant_Profiles { get; set; }
    }
}
