using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NGService.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryId { get; set; }
        public int DeliveryBranchDispatchId { get; set; }
        public int DeliveryDestinationBranchId { get; set; }
        public ServiceBranch ServiceBranchDispatch { get; set; }
        public ServiceBranch ServiceBranchDestinatin { get; set; } 
    }
}