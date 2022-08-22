using GeneralWebApplication.BusinessLayer.Abstract;
using GeneralWebApplication.DataAccessLayer.Abstract;
using GeneralWebApplication.DataAccessLayer.Repositories;
using GeneralWebApplication.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.BusinessLayer.Concrete
{
    public class ArticleCategoryManager : IArticleCategoryService
    {
        IArticleCategoryRepository _articleCategory;


        public ArticleCategoryManager(IArticleCategoryRepository articleCategory)
        {
            _articleCategory = articleCategory;
        }

        public void Add(ArticleCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ArticleCategory entity)
        {
            throw new NotImplementedException();
        }

        public List<ArticleCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public ArticleCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ArticleCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
