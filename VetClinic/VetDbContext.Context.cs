﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetClinic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetClinicdbConnection : DbContext
    {
        public PetClinicdbConnection()
            : base("name=PetClinicdbConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Avatar> Avatars { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vet> Vets { get; set; }
    }
}