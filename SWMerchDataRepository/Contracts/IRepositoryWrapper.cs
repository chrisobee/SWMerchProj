using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Contracts
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customer { get; }
        IOrderRepository Order { get; }
        IProductRepository Product { get; }
        IPurchasedProductRepository PurchasedProduct { get; }
        IAdvancedUserSettingsRepository AdvancedUserSettings { get; }

        void Save();
    }
}
