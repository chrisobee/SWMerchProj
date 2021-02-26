using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface ICartRepository: IRepositoryBase<Cart>
    {
        public Task<Cart> GetCartById(int cartId);
    }
}
