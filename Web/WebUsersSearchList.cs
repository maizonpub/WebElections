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
    
    public partial class WebUsersSearchList
    {
        public long id { get; set; }
        public Nullable<long> WebUserId { get; set; }
        public Nullable<int> SearchListId { get; set; }
        public string Phone { get; set; }
        public string Khasa2iss { get; set; }
        public string Email { get; set; }
        public string sakan { get; set; }
        public string marga3 { get; set; }
    
        public virtual SearchList SearchList { get; set; }
        public virtual WebUser WebUser { get; set; }
    }
}