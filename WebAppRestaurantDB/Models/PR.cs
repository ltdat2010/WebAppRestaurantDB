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
    
    public partial class PR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR()
        {
            this.PRLines = new HashSet<PRLine>();
        }
    
        public int Id { get; set; }
        public string PRNo { get; set; }
        public Nullable<System.DateTime> PRDate { get; set; }
        public string Reason { get; set; }
        public string RequestedBy { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public string CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckedDate { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<bool> CheckedStatus { get; set; }
        public Nullable<bool> ApprovedStatus { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<bool> Locked { get; set; }
        public string Note { get; set; }
        public string DeptCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRLine> PRLines { get; set; }
    }
}
