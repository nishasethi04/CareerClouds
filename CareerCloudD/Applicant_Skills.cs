//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloudD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applicant_Skills
    {
        public System.Guid Id { get; set; }
        public System.Guid Applicant { get; set; }
        public string Skill { get; set; }
        public string Skill_Level { get; set; }
        public byte Start_Month { get; set; }
        public int Start_Year { get; set; }
        public byte End_Month { get; set; }
        public int End_Year { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        public virtual Applicant_Profiles Applicant_Profiles { get; set; }
    }
}
