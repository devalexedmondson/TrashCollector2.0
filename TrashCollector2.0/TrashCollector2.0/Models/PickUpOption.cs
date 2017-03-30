using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector2._0.Models
{
    public class PickUpOption
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
    }
}