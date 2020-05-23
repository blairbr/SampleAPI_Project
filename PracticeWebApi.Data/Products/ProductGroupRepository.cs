using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Data.Products
{
    public class ProductGroupRepository : IProductGroupRepository
    {
        public Task AddGroup(ProductGroupDataEntity productGroupDataEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductGroup(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ProductGroupDataEntity>> GetAllProductGroups()
        {
            throw new NotImplementedException();
        }
    }
}
