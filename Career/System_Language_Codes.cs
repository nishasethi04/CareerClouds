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
    
    public partial class System_Language_Codes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public System_Language_Codes()
        {
            this.Company_Descriptions = new HashSet<Company_Descriptions>();
        }
    
        public string LanguageID { get; set; }
        public string Name { get; set; }
        public string Native_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_Descriptions> Company_Descriptions { get; set; }
    }
}
