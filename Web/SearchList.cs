//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class SearchList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SearchList()
        {
            this.WebUsersSearchLists = new HashSet<WebUsersSearchList>();
        }
    
        public int id { get; set; }
        public string ta2ifa { get; set; }
        public string street { get; set; }
        public string segel { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MotherName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string VoterID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebUsersSearchList> WebUsersSearchLists { get; set; }
    }
}
