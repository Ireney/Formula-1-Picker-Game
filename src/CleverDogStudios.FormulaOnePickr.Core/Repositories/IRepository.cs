using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CleverDogStudios.FormulaOnePickr.Core.Repositories
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        IList<T> FindBy(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entitty);
        void Save();
    }
}
