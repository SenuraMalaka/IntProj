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
    
    public partial class Lecturer
    {
        public Lecturer()
        {
            this.Lecturer_Hall = new HashSet<Lecturer_Hall>();
        }
    
        public string Username { get; set; }
        public string Subject { get; set; }
        public string Qualification { get; set; }
        public Nullable<decimal> Salary { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Lecturer_Hall> Lecturer_Hall { get; set; }
    }
}
