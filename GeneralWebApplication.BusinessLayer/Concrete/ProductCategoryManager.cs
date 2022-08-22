using GeneralWebApplication.BusinessLayer.Abstract;
using GeneralWebApplication.DataAccessLayer.Abstract;
using GeneralWebApplication.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.BusinessLayer.Concrete
{
    public class ProductCategoryManager : IProductCategoryService
    {
       readonly IProductCategoryRepository _productCategory;

        public ProductCategoryManager(IProductCategoryRepository productCategory)
        {
            _productCategory = productCategory;
        }

        public void Add(ProductCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductCategory entity)
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
