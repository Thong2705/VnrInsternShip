﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VNR_InternShipEntities : DbContext
    {
        public VNR_InternShipEntities()
            : base("name=VNR_InternShipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
    }
}
