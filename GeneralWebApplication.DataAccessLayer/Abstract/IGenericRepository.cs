using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T t);
        void Delete(T t);

        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);

        List<T> List(Expression<Func<T,bool>> filter);

    }
}
