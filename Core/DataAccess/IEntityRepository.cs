using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{
    public interface IEntityRepository<T, in TKey> where T : class, IEntity<TKey>, new() where TKey : IEquatable<TKey>
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        T GetById(TKey id);
        T Add(T entity);
        T Update(TKey id, T entity);
        T Delete(T entity);
    }
}
