﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.DAL.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMSEntities : DbContext
    {
        public CMSEntities()
            : base("name=CMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<album> album { get; set; }
        public DbSet<@class> @class { get; set; }
        public DbSet<images> images { get; set; }
        public DbSet<journal> journal { get; set; }
        public DbSet<journaltype> journaltype { get; set; }
        public DbSet<leaveword> leaveword { get; set; }
        public DbSet<resources> resources { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<usertitle> usertitle { get; set; }
    }
}