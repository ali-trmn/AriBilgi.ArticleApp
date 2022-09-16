using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace AriBilgi.ArticleApp.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
