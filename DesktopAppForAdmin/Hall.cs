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
    
    public partial class Hall
    {
        public Hall()
        {
            this.Computers = new HashSet<Computer>();
            this.Lecturer_Hall = new HashSet<Lecturer_Hall>();
        }
    
        public string HID { get; set; }
        public string FID { get; set; }
    
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Lecturer_Hall> Lecturer_Hall { get; set; }
    }
}
