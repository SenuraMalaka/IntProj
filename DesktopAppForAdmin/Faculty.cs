//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopAppForAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        public Faculty()
        {
            this.Batches = new HashSet<Batch>();
            this.Halls = new HashSet<Hall>();
            this.Labs = new HashSet<Lab>();
        }
    
        public string FID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual ICollection<Hall> Halls { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
    }
}
