//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization_Service
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CodeId { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CreatedById { get; set; }
    
        public virtual Codes_AgentService Codes_AgentService { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
