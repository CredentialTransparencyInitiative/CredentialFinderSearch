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
    
    public partial class CIPCode2010_JobFamily
    {
        public CIPCode2010_JobFamily()
        {
            this.CIPCode2010 = new HashSet<CIPCode2010>();
        }
    
        public string CIPFamily { get; set; }
        public string CIPTitle { get; set; }
        public string CIPDefinition { get; set; }
        public string Examples { get; set; }
        public Nullable<int> Totals { get; set; }
        public string Url { get; set; }
    
        public virtual ICollection<CIPCode2010> CIPCode2010 { get; set; }
    }
}