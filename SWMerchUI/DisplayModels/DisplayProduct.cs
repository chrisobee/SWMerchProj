using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWMerchUI.DisplayModels
{
    public class DisplayProduct
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name of Product is too long!")]
        [MinLength(1, ErrorMessage = "Name of Product is too short!")]
        public string ProductName { get; set; }

        [Required]
        [Range(0, 500.00, ErrorMessage = "Enter a price between $0 and $500")]
        public double Price { get; set; }
        
        [MinLength(1, ErrorMessage = "Enter a valid Image Url!")]
        public string ImgUrl { get; set; }
        
        [StringLength(100, ErrorMessage = "Short Description is too long!")]
        [MinLength(1, ErrorMessage = "Enter a valid Short Description of Product!")]
        public string ShortDesc { get; set; }
        
        [StringLength(5000, ErrorMessage = "Description is too long!")]
        [MinLength(1, ErrorMessage = "Enter a valid Long Description of Product!")]
        public string LongDesc { get; set; }

        [Range(0, 100, ErrorMessage = "Enter a Point Value between 0 and 100")]
        public double MoralityPoints { get; set; }
    }
}
