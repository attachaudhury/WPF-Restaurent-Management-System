﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RMSDBEntities : DbContext
    {
        public RMSDBEntities()
            : base("name=RMSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_Deal> tbl_Deal { get; set; }
        public virtual DbSet<tbl_DealFoodItem> tbl_DealFoodItem { get; set; }
        public virtual DbSet<tbl_DeliveryQueue> tbl_DeliveryQueue { get; set; }
        public virtual DbSet<tbl_Deposit> tbl_Deposit { get; set; }
        public virtual DbSet<tbl_DepositHead> tbl_DepositHead { get; set; }
        public virtual DbSet<tbl_DetuctInventory> tbl_DetuctInventory { get; set; }
        public virtual DbSet<tbl_Expence> tbl_Expence { get; set; }
        public virtual DbSet<tbl_ExpenceHead> tbl_ExpenceHead { get; set; }
        public virtual DbSet<tbl_ExpenceSubHead> tbl_ExpenceSubHead { get; set; }
        public virtual DbSet<tbl_FinanceChart> tbl_FinanceChart { get; set; }
        public virtual DbSet<tbl_FoodItem> tbl_FoodItem { get; set; }
        public virtual DbSet<tbl_FoodItemCategory> tbl_FoodItemCategory { get; set; }
        public virtual DbSet<tbl_KitchenInventory> tbl_KitchenInventory { get; set; }
        public virtual DbSet<tbl_KitchenInventoryCategory> tbl_KitchenInventoryCategory { get; set; }
        public virtual DbSet<tbl_PaymentMode> tbl_PaymentMode { get; set; }
        public virtual DbSet<tbl_PurchaseOrder> tbl_PurchaseOrder { get; set; }
        public virtual DbSet<tbl_PurchaseOrderItem> tbl_PurchaseOrderItem { get; set; }
        public virtual DbSet<tbl_Sale> tbl_Sale { get; set; }
        public virtual DbSet<tbl_SaleItem> tbl_SaleItem { get; set; }
        public virtual DbSet<tbl_Sitting> tbl_Sitting { get; set; }
        public virtual DbSet<tbl_Staff> tbl_Staff { get; set; }
        public virtual DbSet<tbl_StaffCategory> tbl_StaffCategory { get; set; }
        public virtual DbSet<tbl_Supplier> tbl_Supplier { get; set; }
    }
}
