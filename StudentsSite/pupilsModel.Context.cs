﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShimiTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class pupilsEntities : DbContext
    {
        public pupilsEntities()
            : base("name=pupilsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    
        public virtual ObjectResult<GetAllStudents_Result> GetAllStudents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllStudents_Result>("GetAllStudents");
        }
    }
}
