using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<IEnumerable<T>> Select(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> SelectAll();

    }
}
