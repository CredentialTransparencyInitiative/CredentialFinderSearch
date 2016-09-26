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
    
    public partial class LearningOpportunity
    {
        public LearningOpportunity()
        {
            this.Entity_LearningOpportunity = new HashSet<Entity_LearningOpportunity>();
        }
    
        public int Id { get; set; }
        public System.Guid RowId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Nullable<System.DateTime> DateEffective { get; set; }
        public Nullable<System.Guid> ProviderUid { get; set; }
        public string LearningResourceUrl { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdatedById { get; set; }
        public string IdentificationCode { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> ManagingOrgId { get; set; }
        public string AvailableOnlineAt { get; set; }
    
        public virtual ICollection<Entity_LearningOpportunity> Entity_LearningOpportunity { get; set; }
        public virtual Organization Organization { get; set; }
    }
}