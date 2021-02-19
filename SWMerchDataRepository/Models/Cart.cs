using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [NotMapped]
        public List<Product> ProductsInCart { get; set; }
    }
}
