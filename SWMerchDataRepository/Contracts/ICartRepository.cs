using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface ICartRepository: IRepositoryBase<Cart>
    {
        public Task AddProductToCart(int cartId, int productId);
        public Task SetQuantity(int cartId, int productId, int qty);
        public Task RemoveProductFromCart(int cartId, int productId);
    }
}
