using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public Result Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public Result Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public DataResult<Product> Get(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductID == productId));
        }

        public DataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public DataResult<List<Product>> GetListByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(x => x.CategoryID == categoryId));
        }

        public Result Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
