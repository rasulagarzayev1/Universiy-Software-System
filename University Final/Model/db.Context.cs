﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_Final.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityEntities : DbContext
    {
        public UniversityEntities()
            : base("name=UniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BeforeExamGrade> BeforeExamGrades { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<STG> STGs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
