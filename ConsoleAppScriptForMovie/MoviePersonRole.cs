//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppScriptForMovie
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoviePersonRole
    {
        public long MovieId { get; set; }
        public long PersonId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }
    }
}
