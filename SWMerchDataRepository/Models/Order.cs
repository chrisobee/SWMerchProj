using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
