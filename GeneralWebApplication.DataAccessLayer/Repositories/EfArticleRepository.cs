using GeneralWebApplication.DataAccessLayer.Abstract;
using GeneralWebApplication.DataAccessLayer.Concrete.Context;
using GeneralWebApplication.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.DataAccessLayer.Repositories
{
    public class EfArticleRepository : EfGenericRepository<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }

        public List<Article> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Articles.Include(x => x.ArticleCategory).ToList();
            }
        }
    }
}
