﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HackApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HackhathonEntities1 : DbContext
    {
        public HackhathonEntities1()
            : base("name=HackhathonEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Begeniler> tbl_Begeniler { get; set; }
        public virtual DbSet<tbl_Mesaj> tbl_Mesaj { get; set; }
        public virtual DbSet<tbl_UrunFotograflarİ> tbl_UrunFotograflarİ { get; set; }
        public virtual DbSet<tbl_Urunler> tbl_Urunler { get; set; }
        public virtual DbSet<tbl_UrunTipi> tbl_UrunTipi { get; set; }
        public virtual DbSet<tbl_Uyeler> tbl_Uyeler { get; set; }
    }
}
