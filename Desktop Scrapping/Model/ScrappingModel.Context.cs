﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop_Scrapping.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScrapeTestEntities : DbContext
    {
        public ScrapeTestEntities()
            : base("name=ScrapeTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand_Table> Brand_Table { get; set; }
        public virtual DbSet<Category_Table> Category_Table { get; set; }
        public virtual DbSet<ItemsName> ItemsNames { get; set; }
        public virtual DbSet<ProductsFromEbay> ProductsFromEbays { get; set; }
        public virtual DbSet<ScrapDataTime> ScrapDataTimes { get; set; }
        public virtual DbSet<ScrapEbay> ScrapEbays { get; set; }
        public virtual DbSet<SellerNameScrape> SellerNameScrapes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
