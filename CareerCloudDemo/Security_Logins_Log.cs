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
    
    public partial class Security_Logins_Log
    {
        public System.Guid Id { get; set; }
        public System.Guid Login { get; set; }
        public string Source_IP { get; set; }
        public System.DateTime Logon_Date { get; set; }
        public bool Is_Succesful { get; set; }
    
        public virtual Security_Logins Security_Logins { get; set; }
    }
}
