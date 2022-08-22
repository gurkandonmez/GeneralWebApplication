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
    public class ArticleManager : IArticleService
    {
        readonly IArticleRepository _article;
        public ArticleManager(IArticleRepository article)
        {
            _article = article;
        }

        public void Add(Article entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Article entity)
        {
            throw new NotImplementedException();
        }

        public Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
