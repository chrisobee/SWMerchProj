using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class CartRepository:RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
        }
    }
}
