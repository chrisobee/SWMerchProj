using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SWMerchUI.DisplayModels
{
    public class DisplayAddress
    {
        [Required, Display(Name = "Country")]
        public string Country { get; set; }

        [Required, Display(Name = "Full Name (First and Last Name")]
        public string FullName { get; set; }

        [Required, Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Required, Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required, Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public string State { get; set; }
        public string ProvinceOrRegion { get; set; }

        [Required, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Delivery Instructions (Optional)")]
        public string DeliveryInstructions { get; set; }

        [Display(Name = "Pin or Building Entry Code on Deliery (Optional)")]
        public string EntryCode { get; set; }

        
    }
}
