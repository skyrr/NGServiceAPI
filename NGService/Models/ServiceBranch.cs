using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NGService.Models
{
    public class ServiceBranch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<Delivery> DeliveriesFromBranch { get; set; }
        public List<Delivery> DeliveriesToBranch { get; set; }
    }
}