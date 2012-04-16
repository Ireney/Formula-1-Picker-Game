using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Core.Repositories;
using CleverDogStudios.FormulaOnePickr.Data.DataContexts;

namespace CleverDogStudios.FormulaOnePickr.Data.Drivers
{
    public class DriverRepository : IDriverRepository
    {
        public IList<IDriver> GetAll()
        {
            IList<IDriver> drivers;
                        
            using (var context = new FormulaOnePickrContext())
            {
                var list = (from driver in context.Drivers.Include("Team") select driver);
                drivers = new List<IDriver>(list);
            }

            return drivers;
        }

        public IList<IDriver> FindBy(Expression<Func<IDriver, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(IDriver entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IDriver entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IDriver entitty)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
