﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationsMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RegistrationProcessEntities4 : DbContext
    {
        public RegistrationProcessEntities4()
            : base("name=RegistrationProcessEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Application> Applications { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ProcessedApplication> ProcessedApplications { get; set; }
        public DbSet<Seat> Seats { get; set; }
    }
}
