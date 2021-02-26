using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface IProductInCartRepository : IRepositoryBase<ProductInCart>
    {
        public Task<Product> GetProductInCartById(int cartId, int productId);
        public Task<List<Product>> GetAllProductsInCart(int cartId);
        public Task SetQuantity(int cartId, int productId, int qty);
        public void UpdateProductInCart(ProductInCart productInCart) => Update(productInCart);
    }

}
