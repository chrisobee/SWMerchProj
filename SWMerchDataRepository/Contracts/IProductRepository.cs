using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public Task<Product> GetProductById(int productId);
        public Task<List<Product>> GetAllProducts();
        public void InsertProduct(Product product);
    }
}
