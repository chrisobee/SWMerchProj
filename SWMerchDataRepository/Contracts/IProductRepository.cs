using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public Product GetProductById(int productId);
        public List<Product> GetAllProducts();
    }
}
