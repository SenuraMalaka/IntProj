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
    
    public partial class Staff
    {
        public string Username { get; set; }
        public string Position { get; set; }
        public Nullable<decimal> Salary { get; set; }
    
        public virtual User User { get; set; }
    }
}
