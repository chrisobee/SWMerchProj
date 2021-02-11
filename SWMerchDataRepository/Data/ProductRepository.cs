using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }

        public Product GetProductById(int productId) =>
            FindByCondition(p => p.ProductId == productId).SingleOrDefault();
        public List<Product> GetAllProducts() =>
            FindAll().ToList();


    }
}
