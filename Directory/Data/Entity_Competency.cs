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
    
    public partial class Entity_Competency
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdatedById { get; set; }
        public System.Guid RowId { get; set; }
        public string EducationalFramework { get; set; }
        public string Description { get; set; }
        public string TargetName { get; set; }
        public string TargetDescription { get; set; }
        public string TargetUrl { get; set; }
        public string CodedNotation { get; set; }
        public string AlignmentType { get; set; }
        public Nullable<int> AlignmentTypeId { get; set; }
        public Nullable<System.DateTime> AlignmentDate { get; set; }
        public Nullable<int> EntityFrameworkId { get; set; }
    
        public virtual Entity Entity { get; set; }
    }
}