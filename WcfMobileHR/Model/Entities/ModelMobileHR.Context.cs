﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HumanResourcesDBEntities : DbContext
    {
        public HumanResourcesDBEntities()
            : base("name=HumanResourcesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TerminationWays> TerminationWays { get; set; }
        public virtual DbSet<TypeContracts> TypeContracts { get; set; }
        public virtual DbSet<TypeRates> TypeRates { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<EmploymentHistory> EmploymentHistory { get; set; }
        public virtual DbSet<EmploymentHistoryEducation> EmploymentHistoryEducation { get; set; }
    }
}