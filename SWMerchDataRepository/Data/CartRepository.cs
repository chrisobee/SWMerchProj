using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Data
{
    public class CartRepository:RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
        }

        public async Task<Cart> GetCartById(int cartId)
        {
            var result = await FindByCondition(c => c.CartId == cartId);
            return result.SingleOrDefault();
        }
    }
}
