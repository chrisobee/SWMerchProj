using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Data
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }

        public async Task<Product> GetProductById(int productId)
        {
            var queryResult = await FindByCondition(p => p.ProductId == productId);
            return queryResult.SingleOrDefault();

        }

        public async Task<List<Product>> GetAllProducts()
        {
            var queryResult = await FindAll();
            return queryResult.ToList();
        }

        public void InsertProduct(Product product) => Create(product);
    }
}
