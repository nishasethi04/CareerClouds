//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloudDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applicant_Work_History
    {
        public System.Guid Id { get; set; }
        public System.Guid Applicant { get; set; }
        public string Company_Name { get; set; }
        public string Country_Code { get; set; }
        public string Location { get; set; }
        public string Job_Title { get; set; }
        public string Job_Description { get; set; }
        public short Start_Month { get; set; }
        public int Start_Year { get; set; }
        public short End_Month { get; set; }
        public int End_Year { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        public virtual Applicant_Profiles Applicant_Profiles { get; set; }
        public virtual System_Country_Codes System_Country_Codes { get; set; }
    }
}
