using GeneralWebApplication.DataAccessLayer.Abstract;
using GeneralWebApplication.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.DataAccessLayer.Repositories
{
    internal class EfProductCategoryRepository : EfGenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public EfProductCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
