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
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Contracts = new HashSet<Contracts>();
            this.Departments = new HashSet<Departments>();
            this.EmploymentHistory = new HashSet<EmploymentHistory>();
            this.EmploymentHistoryEducation = new HashSet<EmploymentHistoryEducation>();
        }
    
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<System.DateTime> DateBirth { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string AdressEmail { get; set; }
        public Nullable<System.DateTime> IsseuDateIdentityCard { get; set; }
        public Nullable<System.DateTime> ExpirationDateIdentityCard { get; set; }
        public string PassportNumber { get; set; }
        public Nullable<System.DateTime> IssueDatePassport { get; set; }
        public Nullable<System.DateTime> ExpirationDatePassport { get; set; }
        public int StatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual Genders Genders { get; set; }
        public virtual Statuses Statuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentHistory> EmploymentHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentHistoryEducation> EmploymentHistoryEducation { get; set; }
    }
}
