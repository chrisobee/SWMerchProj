using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class ProductInCartRepository : RepositoryBase<ProductInCart>, IProductInCartRepository
    {
        public ProductInCartRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        { 
        }
    }
}
