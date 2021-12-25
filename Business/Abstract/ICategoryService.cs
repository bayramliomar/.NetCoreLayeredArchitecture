using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        DataResult<Category> Get(int categoryId);
        DataResult<List<Category>> GetList();
        Result Add(Category category);
        Result Delete(Category category);
        Result Update(Category category);
    }
}
