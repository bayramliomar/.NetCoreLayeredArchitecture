using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        DataResult<Product> Get(int productId);
        DataResult<List<Product>> GetList();
        DataResult<List<Product>> GetListByCategoryId(int categoryId);
        Result Add(Product product);
        Result Delete(Product product);
        Result Update(Product product);

    }
}
