using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Data.Products
{
    public class ProductRepository : IProductRepository
    {
        public Task ActivateProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDataEntity> AddProduct(ProductDataEntity product)
        {
            throw new NotImplementedException();
        }

        public Task DeactiveProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDataEntity> FindProductById(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ProductDataEntity>> GetProductsByGroupId(string groupId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(ProductDataEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
