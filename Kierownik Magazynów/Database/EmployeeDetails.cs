//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kierownik_Magazynów.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeDetails
    {
        public int DetailsId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime HireDate { get; set; }
        public Nullable<System.DateTime> DismissDate { get; set; }
        public Nullable<int> SupervisorId { get; set; }
        public string DefaultActivity { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
