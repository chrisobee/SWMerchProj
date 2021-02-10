using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Email { get; set; }
        public DateTime DatePurchased { get; set; }
        public double Taxes { get; set; }
    }
}
