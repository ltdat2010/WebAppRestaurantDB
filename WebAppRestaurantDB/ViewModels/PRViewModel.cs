using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.ViewModels
{
    public class PRViewModel
    {
        public PRViewModel()
        {

        }
        public int Id { get; set; }
        public string PRNo { get; set; }
        public string SelectedDeptCode { get; set; }
        public Department SelectedDepartment { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<PRLineViewModel> PRLines { get; set; }
    }
}