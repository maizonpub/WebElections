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
    
    public partial class cms_policies
    {
        public int id { get; set; }
        public Nullable<int> permissionId { get; set; }
        public Nullable<int> groupId { get; set; }
        public string event_permitted { get; set; }
    
        public virtual cms_groups cms_groups { get; set; }
        public virtual cms_permissions cms_permissions { get; set; }
    }
}
