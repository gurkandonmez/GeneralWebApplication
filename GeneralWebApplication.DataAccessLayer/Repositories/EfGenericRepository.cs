using GeneralWebApplication.DataAccessLayer.Abstract;
using GeneralWebApplication.DataAccessLayer.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.DataAccessLayer.Repositories
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public EfGenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T t)
        {
           _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {

            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
      
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
     
            return _context.Set<T>().ToList();
           
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
          return   c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
