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
    
    public partial class Contracts
    {
        public int ID { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> TypeContractsID { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> TypeRateId { get; set; }
        public Nullable<int> TerminationWayId { get; set; }
    
        public virtual Currencies Currencies { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Positions Positions { get; set; }
        public virtual TerminationWays TerminationWays { get; set; }
        public virtual TypeContracts TypeContracts { get; set; }
        public virtual TypeRates TypeRates { get; set; }
    }
}
