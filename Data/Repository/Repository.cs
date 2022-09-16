using AriBilgi.ArticleApp.Data.Contexts;
using AriBilgi.ArticleApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AriBilgi.ArticleApp.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ArticleContext _context;

        public Repository(ArticleContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }
    }
}
