using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector2._0.Models
{
    public class ChangeDayViewModel
    {
        [Required]
        public string PickUpDay { get; set; }
    }

    public class AddAddressViewModel
    {
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
       
    }
    public class VacationDayViewModel
    {

    }
}