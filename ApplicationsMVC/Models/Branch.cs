//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationsMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branch
    {
        public Branch()
        {
            this.Applications = new HashSet<Application>();
        }
    
        public int branch_id { get; set; }
        public string contact_person { get; set; }
        public string location { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
    }
}
