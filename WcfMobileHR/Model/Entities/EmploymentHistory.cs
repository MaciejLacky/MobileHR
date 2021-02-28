//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfMobileHR.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmploymentHistory
    {
        public int ID { get; set; }
        public string EmployerName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> TypeContractId { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> TerminationWayId { get; set; }
        public string Comments { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual TerminationWays TerminationWays { get; set; }
        public virtual TypeContracts TypeContracts { get; set; }
    }
}