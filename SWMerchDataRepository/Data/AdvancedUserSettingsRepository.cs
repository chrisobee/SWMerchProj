using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class AdvancedUserSettingsRepository : RepositoryBase<AdvancedUserSettings>, IAdvancedUserSettingsRepository
    {
        public AdvancedUserSettingsRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
        }
    }
}
