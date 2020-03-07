using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppRestaurantDB.ViewModels
{
    public class VehicleViewModel
    {
        public VehicleViewModel()
        {

        }
        public IEnumerable<SelectListItem> MakeModelsList { get; set; }
        public IEnumerable<SelectListItem> VehicleModelsList { get; set; }
        public int SelectedMakeId { get; set; }
        public int SelectedVehicleId { get; set; }
    }
}