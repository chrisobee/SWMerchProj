using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string FullName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }      
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string ProvinceOrRegion { get; set; }
        public string PhoneNumber { get; set; }
        public string DeliveryInstructions { get; set; }
        public string EntryCode { get; set; }


        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
