//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_PurchaseOrder
    {
        public int Id { get; set; }
        public Nullable<int> Supplier_id { get; set; }
        public Nullable<System.DateTime> DatenTime { get; set; }
    
        public virtual tbl_Supplier tbl_Supplier { get; set; }
    }
}
