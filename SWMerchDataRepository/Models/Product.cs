using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public double MoralityPoints { get; set; }
    }
}
