//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppRestaurantDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRLine
    {
        public int Id { get; set; }
        public string PRNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UoM { get; set; }
        public Nullable<decimal> InStock { get; set; }
        public Nullable<decimal> QtyRequest { get; set; }
        public Nullable<System.DateTime> NeededDate { get; set; }
        public Nullable<bool> PRLinesStatus { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual PR PR { get; set; }
    }
}