using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Select(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        //private MySqlContext context = new MySqlContext();

        //public void Insert(T obj)
        //{
        //    context.Set<T>().Add(obj);
        //    context.SaveChanges();
        //}

        //public void Update(T obj)
        //{
        //    context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    context.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    context.Set<T>().Remove(Select(id));
        //    context.SaveChanges();
        //}

        //public IList<T> Select()
        //{
        //    return context.Set<T>().ToList();
        //}

        //public T Select(int id)
        //{
        //    return context.Set<T>().Find(id);
        //}

    }
}