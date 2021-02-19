using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public long? CardExpiryMonth { get; set; }
        public long? CardExpiryYear { get; set; }
        public string CardCvc { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
