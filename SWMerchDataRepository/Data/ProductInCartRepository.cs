using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Data
{
    public class ProductInCartRepository : RepositoryBase<ProductInCart>, IProductInCartRepository
    {
        public ProductInCartRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        { 
        }

        public async Task<List<Product>> GetAllProductsInCart(int cartId)
        {
            var result = await FindByCondition(p => p.CartId == cartId);
            if(result != null)
            {
                return result.Select(p => p.Product).ToList();
            }
            return null;
        }

        public async Task<Product> GetProductInCartById(int cartId, int productId)
        {
            var result = await FindByCondition(p => p.CartId == cartId && p.ProductId == productId);
            if(result != null)
            {
                return result.Select(p => p.Product).SingleOrDefault();
            }
            return null;
        }

        public async Task SetQuantity(int cartId, int productId, int qty)
        {
            var result = await FindByCondition(p => p.CartId == cartId && p.ProductId == productId);
            ProductInCart productInCart = result.SingleOrDefault();
            productInCart.Quantity = qty;
            Update(productInCart);
        }
    }
}
