using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWMerchDataRepository.Models
{
    public class AdvancedUserSettings
    {
        [Key]
        public int UserSettingsId { get; set; }
        public string Theme { get; set; }
        public string Format { get; set; }
    }
}
