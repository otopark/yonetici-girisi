﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcbir.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mvcporEntities : DbContext
    {
        public mvcporEntities()
            : base("name=mvcporEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ARACGİRCIK> ARACGİRCIK { get; set; }
        public virtual DbSet<MÜSTERI> MÜSTERI { get; set; }
        public virtual DbSet<PARKBILGISI> PARKBILGISI { get; set; }
        public virtual DbSet<PERSONEL> PERSONEL { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ÜCRET> ÜCRET { get; set; }
        public virtual DbSet<YÖNETİCİ> YÖNETİCİ { get; set; }
    }
}
